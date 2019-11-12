using System;
using System.Security;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Вспомогательные методы
    /// </summary>
    public class Helper
    {

        public static SecureString BuildSecureStringPassword(string password)
        {
            var secure = new SecureString();
            foreach (char passwordChar in password)
            {
                secure.AppendChar(passwordChar);
            }
            return secure;
        }

        public static byte[] HexStringToByteArray(String hex)
        {
            if (hex.Substring(0, 2) == "0x")
            {
                hex = hex.Substring(2);
            }
            hex = hex.Replace(" ", "");
            hex = hex.Replace(" ", "");

            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static string ByteArrayToHexString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static byte[] TrimArray(byte[] targetArray)
        {
            IEnumerator enum1 = targetArray.GetEnumerator();
            int i = 0;
            while (enum1.MoveNext())
            {
                if (enum1.Current.ToString().Equals("0"))
                {
                    break;
                }
                i++;
            }
            byte[] returnedArray = new byte[i];
            for (int j = 0; j < i; j++)
            {
                returnedArray[j] = targetArray[j];
            }
            return returnedArray;
        }

        public static byte[] TrimArray(byte[] targetArray, int lenght)
        {
            byte[] returnedArray = new byte[lenght];
            for (int j = 0; j < lenght; j++)
            {
                returnedArray[j] = targetArray[j];
            }
            return returnedArray;
        }

        public static byte[] FileToByteArray(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }

        public static byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static object  ByteArrayToObject(byte[] ba)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(ba))
            {
                return bf.Deserialize(ms);
            }
        }
    }
}
