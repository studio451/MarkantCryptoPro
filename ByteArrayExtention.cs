using System.Text;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Расширение для типа byte[]
    /// </summary>
    internal static class ByteArrayExtension
    {
        /// <summary>
        /// Печатает byte[] как HEX строку.
        /// </summary>
        /// <param name="ba">Массив байт</param>
        /// <returns>HEX строка</returns>
        internal static string ToHexString(this byte[] ba)
        {
            var hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:X2}", b);
            return hex.ToString();
        }
    }    
}
