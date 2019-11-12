using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Представляет код типа поставщика для System.Security.Cryptography.CspParameters
    /// </summary>
    public enum ProviderType
    {
        /// <summary>
        /// ГОСТ Р 34.10-2012 (256)
        /// </summary>
        GOST_R_34_10_2012_256 = 80,
        /// <summary>
        /// ГОСТ Р 34.10-2012 (512)
        /// </summary>
        GOST_R_34_10_2012_512 = 81,
    }
}
