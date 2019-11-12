using System.Security;
using System.Security.Cryptography;

namespace MarkantCryptoPro
{
    /// <summary>
    /// Класс с параметрами для инициализации контейнера крипровайдера
    /// </summary>
    public class ProviderInitData
    {
        public ProviderType ProviderType { get; set; }
        public string ProviderContainerName { get; set; }
        public SecureString ProviderPassword { get; set; }

        public ProviderInitData(string providerContainerName, string providerPassword, ProviderType providerType = ProviderType.GOST_R_34_10_2012_256)
        {
            ProviderContainerName = providerContainerName;
            ProviderPassword = Helper.BuildSecureStringPassword(providerPassword);
            ProviderType = providerType;
        }
    }
}
