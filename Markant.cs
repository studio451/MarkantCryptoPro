using Net.Asn1.Reader;
using Net.Asn1.Writer;
using System;
using System.IO;
using System.Numerics;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Класс для передачи сессионного ключа с дополнительной информацией
    /// </summary>
    public class Markant
    {
        /// <summary>
        /// Версия структуры
        /// </summary>
        public int Version = 1;

        /// <summary>
        /// Зашифрованная ключевая информация (сессионный ключ)
        /// </summary>
        public byte[] SessionKey;
                       
        /// <summary>
        /// Синхропосылка сессионного ключа
        /// </summary>
        public byte[] IV;

        /// <summary>
        /// Открытый ключ
        /// </summary>
        public byte[] PublicKey;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Markant()
        {

        }

        /// <summary>
        /// Декодируем из байтового массива в формате ASN1
        /// </summary>
        /// <param name="baAsn1">Байтовый массив в формате ASN1</param>
        /// <returns>Текстовое представление пакета ASN1</returns>
        public string DecodeFromAsn1(byte[] baAsn1)
        {
            var memoryStream = new MemoryStream(baAsn1);
            using (var berReader = new BerReader(memoryStream))
            {
                //Формируем маркант
                try
                {
                    var node = berReader.ReadToEnd().ChildNodes[0];
                    string result = "";
                    foreach (var childNode in node.ChildNodes)
                    {
                        result = berReader.PrintStructure(childNode, result, 1, true);
                    }                    

                    Version = (int)node.ChildNodes[0].ReadContentAsBigInteger();

                    SessionKey = node.ChildNodes[1].RawValue;

                    IV = node.ChildNodes[2].RawValue;

                    PublicKey = node.ChildNodes[3].RawValue;

                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception("Invalid markant format", e);
                }
            }



        }

        /// <summary>
        /// Кодируем в формат ASN1
        /// </summary>
        /// <returns>Байтовый массив в формате ASN1</returns>
        public byte[] EncodeToAsn1()
        {

            var root = new System.Collections.Generic.List<Asn1ObjectBase>();

            root.Add(new Asn1Integer(new BigInteger(Version)));
            root.Add(_asn1BitString(SessionKey));
            root.Add(_asn1BitString(IV));
            root.Add(_asn1BitString(PublicKey));

            var ms = new MemoryStream();
            new DerWriter(ms).Write(new Asn1Sequence(0, root));
            return ms.ToArray();
        }

        /// <summary>
        /// Формирует строка со структурным представлением байтового массива в формате ASN1
        /// </summary>
        /// <param name="baAsn1">Байтовый массив в формате ASN1</param>
        /// <returns>Строка с текстовым представлением байтового массива в формате ASN1</returns>
        public static string PrintFromAsn1(byte[] baAsn1)
        {
            var memoryStream = new MemoryStream(baAsn1);
            using (var berReader = new BerReader(memoryStream))
            {
                //Формируем текстовое представление марканта
                try
                {
                    var node = berReader.ReadToEnd().ChildNodes[0];
                    string result = "ASN1:";
                    foreach (var childNode in node.ChildNodes)
                    {
                        result = berReader.PrintStructure(childNode, result, 1, true);
                    }

                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception("Invalid ASN format", e);
                }
            }
        }

        /// <summary>
        /// Переопределен. Возвращает дамп объекта
        /// </summary>
        /// <returns>Строка с дампом объекта</returns>
        public override string ToString()
        {
            return ObjectDumper.Dump(this);
        }

        private Asn1ObjectBase _asn1BitString(byte[] ba)
        {
            if (ba == null)
            {
                return new Asn1Null();
            }
            else
            {
                return new Asn1BitString(ba, 0);
            }
        }
        private Asn1ObjectBase _asn1OctetString(byte[] ba)
        {
            if (ba == null)
            {
                return new Asn1Null();
            }
            else
            {
                return new Asn1OctetString(ba);
            }
        }
    }
}
