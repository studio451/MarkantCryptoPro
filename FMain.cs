using CryptoPro.Sharpei;
using System;
using System.Text;
using System.Windows.Forms;

namespace MarkantCryptoPro
{
    public partial class FMain : Form
    {
        Markant currentMarkant = null;
        Gost28147 currentGost28147 = null;

        public FMain()
        {
            InitializeComponent();
        }
        byte[] baEncrypt;


        private void bCreateMarkant_Click(object sender, EventArgs e)
        {
            currentMarkant = null;

            tbMarkantHex.Text = "";
            tbMarkantASN1.Text = "";
            tbCurrentMarkant.Text = "";

            if (currentGost28147 != null)
            {
                //Выбираем алгоритм и шифруем сессионный ключ
                if (rbKeyAgree.Checked)
                {
                    currentMarkant = MarkantManager.CreateMarkantWithKeyAgree(currentGost28147, tbCertFile.Text, new ProviderInitData(cbProviderNameSender.Text, cbProviderPasswordSender.Text));
                }
                else
                {
                    currentMarkant = MarkantManager.CreateMarkantWithKeyExchangeFormatter(currentGost28147, tbCertFile.Text);
                }


                tbCurrentMarkant.Text = currentMarkant.ToString();
                tbMarkantHex.Text = Helper.ByteArrayToHexString(currentMarkant.EncodeToAsn1());
                tbMarkantASN1.Text = Markant.PrintFromAsn1(currentMarkant.EncodeToAsn1());

            }
            else
            {
                MessageBox.Show("Отсутствует сессионный ключ!", "Создание марканта");
            }
        }
        private void bDecryptMarkant_Click(object sender, EventArgs e)
        {
            currentGost28147 = null;
            pGost28147Green.Visible = false;
            pGost28147Red.Visible = true;

            if (currentMarkant != null)
            {
                try
                {
                    //Выбираем алгоритм и дешифруем сессионный ключ
                    if (rbKeyAgree.Checked)
                    {
                        currentGost28147 = MarkantManager.DecryptMarkantWithKeyAgree(currentMarkant, new ProviderInitData(cbProviderName.Text, cbProviderPassword.Text));
                    }
                    else
                    {
                        currentGost28147 = MarkantManager.DecryptMarkantWithKeyExchangeFormatter(currentMarkant, new ProviderInitData(cbProviderName.Text, cbProviderPassword.Text));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Source + ": " + exc.Message, "Дешифровка сессионного ключа текущего марканта");
                }
            }
            else
            {
                MessageBox.Show("Текущий маркант пустой!", "Дешифровка сессионного ключа текущего марканта");
            }

            if (currentGost28147 != null)
            {
                pGost28147Red.Visible = false;
                pGost28147Green.Visible = true;
            }
        }
        private void bEncrypt_Click(object sender, EventArgs e)
        {
            tbEncryptText.Text = "";
            tbDecryptText.Text = "";

            //Шифруем текст
            if (currentGost28147 != null)
            {
                baEncrypt = MarkantManager.Gost28147Encrypt(currentGost28147, Encoding.UTF8.GetBytes(tbSourceText.Text));
                tbEncryptText.Text = Helper.ByteArrayToHexString(baEncrypt);
            }
            else
            {
                MessageBox.Show("Отсутствует сессионный ключ!", "Шифрование");
            }
        }
        private void bDecrypt_Click(object sender, EventArgs e)
        {
            tbDecryptText.Text = "";

            //Дешифруем текст
            if (currentGost28147 != null)
            {
                byte[] baDecrypt = MarkantManager.Gost28147Decrypt(currentGost28147, baEncrypt);
                tbDecryptText.Text = Encoding.UTF8.GetString(baDecrypt);
            }
            else
            {
                MessageBox.Show("Отсутствует сессионный ключ!", "Шифрование");
            }
        }
        private void bCreateGost28147_Click(object sender, EventArgs e)
        {
            currentGost28147 = null;
            pGost28147Green.Visible = false;
            pGost28147Red.Visible = true;

            //Создаем случайный сессионный ключ
            currentGost28147 = new Gost28147CryptoServiceProvider();
            if (currentGost28147 != null)
            {
                pGost28147Green.Visible = true;
                pGost28147Red.Visible = false;
            }
        }
        private void bClearGost28147_Click(object sender, EventArgs e)
        {
            currentGost28147 = null;
            pGost28147Green.Visible = false;
            pGost28147Red.Visible = true;
        }

        private void bMarkantClear_Click(object sender, EventArgs e)
        {
            tbMarkantHex.Text = "";
            tbMarkantASN1.Text = "";
            tbCurrentMarkant.Text = "";
            currentMarkant = null;
        }

        private void tbSourceText_TextChanged(object sender, EventArgs e)
        {
            tbEncryptText.Text = "";
            tbDecryptText.Text = "";
        }

        private void RbKeyAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKeyAgree.Checked)
            {
                cbProviderNameSender.Enabled = true;
                cbProviderPasswordSender.Enabled = true;
            }
            else
            {
                cbProviderNameSender.Enabled = false;
                cbProviderPasswordSender.Enabled = false;
            }
        }

        private void RbKeyExchangeFormatter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKeyAgree.Checked)
            {
                cbProviderNameSender.Enabled = true;
                cbProviderPasswordSender.Enabled = true;
            }
            else
            {
                cbProviderNameSender.Enabled = false;
                cbProviderPasswordSender.Enabled = false;
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            tbCertFile.Text = Application.StartupPath + "\\KEY1.cer";
        }
    }
}