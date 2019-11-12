using CryptoPro.Sharpei;
using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Класс для выполнения операций над маркантами
    /// </summary>
    public class MarkantManager
    {
        /// <summary>
        /// Создает маркант с помошью KeyExchangeFormatter
        /// </summary>
        /// <param name="gost28147">Сессионный ключ</param>
        /// <param name="certFileName">Путь к файлу сертификата с открытым ключом получателя</param>
        /// <returns>Сгенерированный маркант</returns>
        public static Markant CreateMarkantWithKeyExchangeFormatter(Gost28147 gost28147, string certFileName)
        {
            // Разбираем сертификат получателя
            X509Certificate2 cert = new X509Certificate2(certFileName);
            if (!(cert.PublicKey.Key is Gost3410_2012_256 gost3410))
                throw new CryptographicException("Not a GOST certificate");

            //Создаем форматтер, шифрующий на ассиметричном ключе получателя
            Gost2012_256KeyExchangeFormatter formatter = new Gost2012_256KeyExchangeFormatter(gost3410);
            //GostKeyTransport - формат зашифрованной для безопасной передачи ключевой информации
            GostKeyTransport gostKeyTransport = ((Gost2012_256KeyExchangeFormatter)formatter).CreateKeyExchange(gost28147);

            //Формируем маркант         
            Markant m = new Markant
            {
                Version = 1,
                SessionKey = gostKeyTransport.Encode(),
                IV = gost28147.IV
            };
            return m;
        }

        /// <summary>
        /// Дешифровка марканта с помошью KeyExchangeFormatter
        /// </summary>
        /// <param name="markant">Маркант для дешифровки</param>
        /// <param name="providerInitData">Информация для инициализации контейнера криптопровайдера c закрытым ключом получателя</param>        
        /// <returns>Дешифрованный сессионный ключ</returns>
        public static Gost28147 DecryptMarkantWithKeyExchangeFormatter(Markant markant, ProviderInitData providerInitData)
        {
            //Готовим параметры контейнера
            CspParameters decrypt_cspParameters = new CspParameters
            {
                ProviderType = (int)providerInitData.ProviderType,
                Flags = CspProviderFlags.NoPrompt,
                KeyPassword = providerInitData.ProviderPassword,
                KeyContainerName = providerInitData.ProviderContainerName
            };
            //Открываем контейнер 
            Gost3410_2012_256CryptoServiceProvider decrypt_gost3410 = new Gost3410_2012_256CryptoServiceProvider(decrypt_cspParameters);
            // Деформаттер для ключей, зашифрованных на ассиметричном ключе получателя.
            Gost2012_256KeyExchangeDeformatter decrypt_gostKeyExchangeDeformatter = new Gost2012_256KeyExchangeDeformatter(decrypt_gost3410);
            // Получаем ГОСТ-овый ключ из GostKeyTransport.
            GostKeyTransport gostKeyTransport = new GostKeyTransport();
            gostKeyTransport.Decode(markant.SessionKey);
            Gost28147 decrypt_gost28147 = (Gost28147)decrypt_gostKeyExchangeDeformatter.DecryptKeyExchange(gostKeyTransport);

            if (decrypt_gost28147 == null)
            {
                throw new Exception("Invalid decrypted session key");
            }
            // Устанавливаем синхропосылку.
            decrypt_gost28147.IV = markant.IV;

            return decrypt_gost28147;
        }

        /// <summary>
        /// Создает маркант с помошью ключа согласования
        /// </summary>
        /// <param name="gost28147">Сессионный ключ</param>
        /// <param name="certFileName">Путь к файлу сертификата получателя</param>
        /// <param name="providerInitData">Информация для инициализации контейнера криптопровайдера c закрытым ключом отправителя</param>  
        /// <returns>Сгенерированный маркант</returns>
        public static Markant CreateMarkantWithKeyAgree(Gost28147 gost28147, string certFileName, ProviderInitData providerInitData)
        {
            // Разбираем сертификат получателя
            X509Certificate2 cert = new X509Certificate2(certFileName);
            if (!(cert.PublicKey.Key is Gost3410_2012_256 gost3410))
                throw new CryptographicException("Not a GOST certificate");

            //Готовим параметры контейнера
            CspParameters cspParameters = new CspParameters
            {
                ProviderType = (int)providerInitData.ProviderType,
                Flags = CspProviderFlags.NoPrompt,
                KeyPassword = providerInitData.ProviderPassword,
                KeyContainerName = providerInitData.ProviderContainerName
            };
            //Открываем контейнер 
            Gost3410_2012_256CryptoServiceProvider encrypt_gost3410 = new Gost3410_2012_256CryptoServiceProvider(cspParameters);
            Gost3410Parameters encrypt_gost3410PublicKeyParameters = encrypt_gost3410.ExportParameters(false);
            // Создаем agree ключ
            GostSharedSecretAlgorithm agree = encrypt_gost3410.CreateAgree(gost3410.ExportParameters(false));
            // Зашифровываем симметричный ключ на agree ключе.
            byte[] wrappedKey = agree.Wrap(gost28147, GostKeyWrapMethod.CryptoProKeyWrap);                                   

            //Формируем маркант            
            Markant m = new Markant
            {
                Version = 2,
                SessionKey = wrappedKey,
                IV = gost28147.IV,
                PublicKey = Helper.ObjectToByteArray(encrypt_gost3410PublicKeyParameters)
            };
            return m;
        }

        /// <summary>
        /// Дешифровка марканта с помошью ключа согласования
        /// </summary>
        /// <param name="markant">Маркант для дешифровки</param>
        /// <param name="providerInitData">Информация для инициализации контейнера криптопровайдера c закрытым ключом получателя</param>        
        /// <returns>Дешифрованный сессионный ключ</returns>
        public static Gost28147 DecryptMarkantWithKeyAgree(Markant markant, ProviderInitData providerInitData)
        {
            //Готовим параметры контейнера
            CspParameters decrypt_cspParameters = new CspParameters
            {
                ProviderType = (int)providerInitData.ProviderType,
                Flags = CspProviderFlags.NoPrompt,
                KeyPassword = providerInitData.ProviderPassword,
                KeyContainerName = providerInitData.ProviderContainerName
            };
            //Открываем контейнер 
            Gost3410_2012_256CryptoServiceProvider decrypt_gost3410 = new Gost3410_2012_256CryptoServiceProvider(decrypt_cspParameters);
            // Читаем открытый ключ
            Gost3410Parameters decrypt_gost3410PublicKeyParameters = (Gost3410Parameters)Helper.ByteArrayToObject(markant.PublicKey);
            // Создаем agree ключ
            GostSharedSecretAlgorithm agree = decrypt_gost3410.CreateAgree(decrypt_gost3410PublicKeyParameters);
            // Расшифровываем симметричный ключ на agree
            Gost28147 decrypt_gost28147 = (Gost28147)agree.Unwrap(markant.SessionKey, GostKeyWrapMethod.CryptoProKeyWrap);
            decrypt_gost28147.IV = markant.IV;

            if (decrypt_gost28147 == null)
            {
                throw new Exception("Invalid decrypted session key");
            }
            // Устанавливаем синхропосылку.
            decrypt_gost28147.IV = markant.IV;

            return decrypt_gost28147;
        }

        /// <summary>
        /// Шифрует байтовый массив
        /// </summary>
        /// <param name="key">Сессионный ключ</param>
        /// <param name="sourceBytes">Шифруемый массив байтов</param>
        /// <returns>Зашифрованный массив байтов</returns>
        public static byte[] Gost28147Encrypt(Gost28147 key, byte[] sourceBytes)
        {
            int currentPosition = 0;
            byte[] targetBytes = new byte[1024];
            int sourceByteLength = sourceBytes.Length;

            // Создаем шифратор для ГОСТ.
            CPCryptoAPITransform cryptoTransform = (CPCryptoAPITransform)key.CreateEncryptor();

            // Размер блока считанных байт.
            int inputBlockSize = cryptoTransform.InputBlockSize;
                       
            try
            {
                // Если возможна обработка нескольких блоков:
                if (cryptoTransform.CanTransformMultipleBlocks)
                {
                    int numBytesRead = 0;
                    while (sourceByteLength - currentPosition >= inputBlockSize)
                    {
                        // Преобразуем байты начиная с currentPosition в массиве 
                        // sourceBytes, записывая результат в массив targetBytes.
                        numBytesRead = cryptoTransform.TransformBlock(
                        sourceBytes, currentPosition,
                        inputBlockSize, targetBytes,
                            currentPosition);
                        currentPosition += numBytesRead;
                    }
                    // Преобразуем последний блок.
                    byte[] finalBytes = cryptoTransform.TransformFinalBlock(
                        sourceBytes, currentPosition,
                        sourceByteLength - currentPosition);

                    // Записываем последний зашифрованный блок 
                    // в массив targetBytes.
                    finalBytes.CopyTo(targetBytes, currentPosition);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught unexpected exception:" + ex.ToString());
            }
            // Определяем, может ли CPCryptoAPITransform использоваться повторно.
            if (!cryptoTransform.CanReuseTransform)
            {
                // Освобождаем занятые ресурсы.
                cryptoTransform.Clear();
            }
            // Убираем неиспользуемые байты из массива.
            return Helper.TrimArray(targetBytes, sourceByteLength);
        }

        /// <summary>
        /// Дешифрует байтовый массив с помощью переданного сессионного ключа
        /// </summary>
        /// <param name="key">Сессионный ключ</param>
        /// <param name="encBytes">Массив байтов для дешифровки</param>
        /// <returns>Дешифрованный массив байтов</returns>
        public static byte[] Gost28147Decrypt(Gost28147 key, byte[] encBytes)
        {
            // Создаем дешифратор для ГОСТ
            CPCryptoAPITransform cryptoTransform =
                (CPCryptoAPITransform)key.CreateDecryptor();

            int inputBlockSize = cryptoTransform.InputBlockSize;
            int sourceByteLength = encBytes.Length;
            int currentPosition = 0;
            byte[] targetBytes = new byte[1024];

            try
            {
                int numBytesRead = 0;
                while (sourceByteLength - currentPosition >= inputBlockSize)
                {
                    // Преобразуем байты начиная с currentPosition в массиве 
                    // sourceBytes, записывая результат в массив targetBytes.
                    numBytesRead = cryptoTransform.TransformBlock(
                        encBytes,
                        currentPosition,
                        inputBlockSize,
                        targetBytes,
                        currentPosition);

                    currentPosition += numBytesRead;
                }

                // Преобразуем последний блок.
                byte[] finalBytes = cryptoTransform.TransformFinalBlock(
                    encBytes,
                    currentPosition,
                    sourceByteLength - currentPosition);

                // Записываем последний расшифрованный блок 
                // в массив targetBytes.
                finalBytes.CopyTo(targetBytes, currentPosition);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught unexpected exception:" + ex.ToString());
            }
            // Убираем неиспользуемые байты из массива.
            return Helper.TrimArray(targetBytes, sourceByteLength);
        }

    }
}
