namespace MarkantCryptoPro
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.bCreateMarkant = new System.Windows.Forms.Button();
            this.tbMarkantHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bDecryptMarkant = new System.Windows.Forms.Button();
            this.tbSourceText = new System.Windows.Forms.TextBox();
            this.tbEncryptText = new System.Windows.Forms.TextBox();
            this.tbDecryptText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarkantASN1 = new System.Windows.Forms.TextBox();
            this.tbCurrentMarkant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.bCreateGost28147 = new System.Windows.Forms.Button();
            this.bClearGost28147 = new System.Windows.Forms.Button();
            this.bMarkantClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.pGost28147Red = new System.Windows.Forms.Panel();
            this.pGost28147Green = new System.Windows.Forms.Panel();
            this.cbProviderName = new System.Windows.Forms.ComboBox();
            this.cbProviderPassword = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbProviderPasswordSender = new System.Windows.Forms.ComboBox();
            this.cbProviderNameSender = new System.Windows.Forms.ComboBox();
            this.rbKeyExchangeFormatter = new System.Windows.Forms.RadioButton();
            this.rbKeyAgree = new System.Windows.Forms.RadioButton();
            this.tbCertFile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCreateMarkant
            // 
            this.bCreateMarkant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateMarkant.Location = new System.Drawing.Point(1111, 400);
            this.bCreateMarkant.Name = "bCreateMarkant";
            this.bCreateMarkant.Size = new System.Drawing.Size(248, 34);
            this.bCreateMarkant.TabIndex = 16;
            this.bCreateMarkant.Text = "Создать маркант на сессионном ключе";
            this.bCreateMarkant.UseVisualStyleBackColor = true;
            this.bCreateMarkant.Click += new System.EventHandler(this.bCreateMarkant_Click);
            // 
            // tbMarkantHex
            // 
            this.tbMarkantHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMarkantHex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbMarkantHex.Location = new System.Drawing.Point(15, 202);
            this.tbMarkantHex.Multiline = true;
            this.tbMarkantHex.Name = "tbMarkantHex";
            this.tbMarkantHex.ReadOnly = true;
            this.tbMarkantHex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMarkantHex.Size = new System.Drawing.Size(313, 406);
            this.tbMarkantHex.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Маркант (0x):";
            // 
            // bDecryptMarkant
            // 
            this.bDecryptMarkant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDecryptMarkant.Location = new System.Drawing.Point(1111, 535);
            this.bDecryptMarkant.Name = "bDecryptMarkant";
            this.bDecryptMarkant.Size = new System.Drawing.Size(248, 34);
            this.bDecryptMarkant.TabIndex = 19;
            this.bDecryptMarkant.Text = "Извлечь сессионный ключ из марканта";
            this.bDecryptMarkant.UseVisualStyleBackColor = true;
            this.bDecryptMarkant.Click += new System.EventHandler(this.bDecryptMarkant_Click);
            // 
            // tbSourceText
            // 
            this.tbSourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSourceText.Location = new System.Drawing.Point(15, 25);
            this.tbSourceText.Multiline = true;
            this.tbSourceText.Name = "tbSourceText";
            this.tbSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSourceText.Size = new System.Drawing.Size(313, 144);
            this.tbSourceText.TabIndex = 0;
            this.tbSourceText.Text = "12345678 abcdefg ABCDEFG -+%$ абвгд АБВГД";
            this.tbSourceText.TextChanged += new System.EventHandler(this.tbSourceText_TextChanged);
            // 
            // tbEncryptText
            // 
            this.tbEncryptText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEncryptText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbEncryptText.Location = new System.Drawing.Point(343, 25);
            this.tbEncryptText.Multiline = true;
            this.tbEncryptText.Name = "tbEncryptText";
            this.tbEncryptText.ReadOnly = true;
            this.tbEncryptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbEncryptText.Size = new System.Drawing.Size(370, 144);
            this.tbEncryptText.TabIndex = 2;
            // 
            // tbDecryptText
            // 
            this.tbDecryptText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDecryptText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbDecryptText.Location = new System.Drawing.Point(727, 25);
            this.tbDecryptText.Multiline = true;
            this.tbDecryptText.Name = "tbDecryptText";
            this.tbDecryptText.ReadOnly = true;
            this.tbDecryptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDecryptText.Size = new System.Drawing.Size(370, 144);
            this.tbDecryptText.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Исходный текст:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Зашифрованный текст (0x):";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(724, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дешифрованный текст:";
            // 
            // tbMarkantASN1
            // 
            this.tbMarkantASN1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMarkantASN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbMarkantASN1.Location = new System.Drawing.Point(342, 202);
            this.tbMarkantASN1.Multiline = true;
            this.tbMarkantASN1.Name = "tbMarkantASN1";
            this.tbMarkantASN1.ReadOnly = true;
            this.tbMarkantASN1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMarkantASN1.Size = new System.Drawing.Size(370, 406);
            this.tbMarkantASN1.TabIndex = 9;
            // 
            // tbCurrentMarkant
            // 
            this.tbCurrentMarkant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrentMarkant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tbCurrentMarkant.Location = new System.Drawing.Point(727, 202);
            this.tbCurrentMarkant.Multiline = true;
            this.tbCurrentMarkant.Name = "tbCurrentMarkant";
            this.tbCurrentMarkant.ReadOnly = true;
            this.tbCurrentMarkant.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCurrentMarkant.Size = new System.Drawing.Size(370, 406);
            this.tbCurrentMarkant.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Маркант (Кодировка ASN1):";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(724, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Маркант (Object):";
            // 
            // bEncrypt
            // 
            this.bEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEncrypt.Location = new System.Drawing.Point(1111, 96);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(248, 34);
            this.bEncrypt.TabIndex = 6;
            this.bEncrypt.Text = "Зашифровать текст сессионным ключом";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDecrypt.Location = new System.Drawing.Point(1111, 136);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(248, 34);
            this.bDecrypt.TabIndex = 7;
            this.bDecrypt.Text = "Дешифровать текст сессионным ключом";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // bCreateGost28147
            // 
            this.bCreateGost28147.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCreateGost28147.Location = new System.Drawing.Point(1159, 46);
            this.bCreateGost28147.Name = "bCreateGost28147";
            this.bCreateGost28147.Size = new System.Drawing.Size(97, 34);
            this.bCreateGost28147.TabIndex = 4;
            this.bCreateGost28147.Text = "Создать";
            this.bCreateGost28147.UseVisualStyleBackColor = true;
            this.bCreateGost28147.Click += new System.EventHandler(this.bCreateGost28147_Click);
            // 
            // bClearGost28147
            // 
            this.bClearGost28147.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClearGost28147.Location = new System.Drawing.Point(1262, 46);
            this.bClearGost28147.Name = "bClearGost28147";
            this.bClearGost28147.Size = new System.Drawing.Size(97, 34);
            this.bClearGost28147.TabIndex = 5;
            this.bClearGost28147.Text = "Сбросить";
            this.bClearGost28147.UseVisualStyleBackColor = true;
            this.bClearGost28147.Click += new System.EventHandler(this.bClearGost28147_Click);
            // 
            // bMarkantClear
            // 
            this.bMarkantClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMarkantClear.Location = new System.Drawing.Point(1111, 575);
            this.bMarkantClear.Name = "bMarkantClear";
            this.bMarkantClear.Size = new System.Drawing.Size(248, 34);
            this.bMarkantClear.TabIndex = 20;
            this.bMarkantClear.Text = "Очистить текущий маркант";
            this.bMarkantClear.UseVisualStyleBackColor = true;
            this.bMarkantClear.Click += new System.EventHandler(this.bMarkantClear_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(1108, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Сессионный ключ (ГОСТ 28147-89):";
            // 
            // pGost28147Red
            // 
            this.pGost28147Red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pGost28147Red.BackgroundImage = global::MarkantCryptoPro.Properties.Resources.key_red;
            this.pGost28147Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pGost28147Red.Location = new System.Drawing.Point(1111, 47);
            this.pGost28147Red.Name = "pGost28147Red";
            this.pGost28147Red.Size = new System.Drawing.Size(32, 32);
            this.pGost28147Red.TabIndex = 31;
            // 
            // pGost28147Green
            // 
            this.pGost28147Green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pGost28147Green.BackgroundImage = global::MarkantCryptoPro.Properties.Resources.key_green;
            this.pGost28147Green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pGost28147Green.Location = new System.Drawing.Point(1111, 47);
            this.pGost28147Green.Name = "pGost28147Green";
            this.pGost28147Green.Size = new System.Drawing.Size(32, 32);
            this.pGost28147Green.TabIndex = 29;
            this.pGost28147Green.Visible = false;
            // 
            // cbProviderName
            // 
            this.cbProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProviderName.AutoCompleteCustomSource.AddRange(new string[] {
            "MASTER_KEY_1",
            "MASTER_KEY_2",
            "USER_KEY_1",
            "USER_KEY_2"});
            this.cbProviderName.FormattingEnabled = true;
            this.cbProviderName.Items.AddRange(new object[] {
            "STORAGE1",
            "STORAGE2"});
            this.cbProviderName.Location = new System.Drawing.Point(1111, 468);
            this.cbProviderName.Name = "cbProviderName";
            this.cbProviderName.Size = new System.Drawing.Size(248, 21);
            this.cbProviderName.TabIndex = 17;
            this.cbProviderName.Text = "STORAGE1";
            // 
            // cbProviderPassword
            // 
            this.cbProviderPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProviderPassword.FormattingEnabled = true;
            this.cbProviderPassword.Items.AddRange(new object[] {
            "111111",
            "222222"});
            this.cbProviderPassword.Location = new System.Drawing.Point(1111, 508);
            this.cbProviderPassword.Name = "cbProviderPassword";
            this.cbProviderPassword.Size = new System.Drawing.Size(248, 21);
            this.cbProviderPassword.TabIndex = 18;
            this.cbProviderPassword.Text = "111111";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Сертификат принимающей стороны:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1111, 452);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Имя контейнера принимающей стороны:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1111, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Пароль контейнера  принимающей стороны:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1111, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Пароль контейнера  отправляющей стороны:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1111, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Имя контейнера отправляющей стороны:";
            // 
            // cbProviderPasswordSender
            // 
            this.cbProviderPasswordSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProviderPasswordSender.Enabled = false;
            this.cbProviderPasswordSender.FormattingEnabled = true;
            this.cbProviderPasswordSender.Items.AddRange(new object[] {
            "111111",
            "222222"});
            this.cbProviderPasswordSender.Location = new System.Drawing.Point(1111, 373);
            this.cbProviderPasswordSender.Name = "cbProviderPasswordSender";
            this.cbProviderPasswordSender.Size = new System.Drawing.Size(248, 21);
            this.cbProviderPasswordSender.TabIndex = 15;
            this.cbProviderPasswordSender.Text = "222222";
            // 
            // cbProviderNameSender
            // 
            this.cbProviderNameSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProviderNameSender.AutoCompleteCustomSource.AddRange(new string[] {
            "MASTER_KEY_1",
            "MASTER_KEY_2",
            "USER_KEY_1",
            "USER_KEY_2"});
            this.cbProviderNameSender.Enabled = false;
            this.cbProviderNameSender.FormattingEnabled = true;
            this.cbProviderNameSender.Items.AddRange(new object[] {
            "STORAGE1",
            "STORAGE2"});
            this.cbProviderNameSender.Location = new System.Drawing.Point(1111, 333);
            this.cbProviderNameSender.Name = "cbProviderNameSender";
            this.cbProviderNameSender.Size = new System.Drawing.Size(248, 21);
            this.cbProviderNameSender.TabIndex = 14;
            this.cbProviderNameSender.Text = "STORAGE2";
            // 
            // rbKeyExchangeFormatter
            // 
            this.rbKeyExchangeFormatter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbKeyExchangeFormatter.AutoSize = true;
            this.rbKeyExchangeFormatter.Checked = true;
            this.rbKeyExchangeFormatter.Location = new System.Drawing.Point(1121, 222);
            this.rbKeyExchangeFormatter.Name = "rbKeyExchangeFormatter";
            this.rbKeyExchangeFormatter.Size = new System.Drawing.Size(137, 17);
            this.rbKeyExchangeFormatter.TabIndex = 11;
            this.rbKeyExchangeFormatter.TabStop = true;
            this.rbKeyExchangeFormatter.Text = "Транспорт ГОСТ 3410";
            this.rbKeyExchangeFormatter.UseVisualStyleBackColor = true;
            this.rbKeyExchangeFormatter.CheckedChanged += new System.EventHandler(this.RbKeyExchangeFormatter_CheckedChanged);
            // 
            // rbKeyAgree
            // 
            this.rbKeyAgree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbKeyAgree.AutoSize = true;
            this.rbKeyAgree.Location = new System.Drawing.Point(1121, 241);
            this.rbKeyAgree.Name = "rbKeyAgree";
            this.rbKeyAgree.Size = new System.Drawing.Size(125, 17);
            this.rbKeyAgree.TabIndex = 12;
            this.rbKeyAgree.Text = "Ключ согласования";
            this.rbKeyAgree.UseVisualStyleBackColor = true;
            this.rbKeyAgree.CheckedChanged += new System.EventHandler(this.RbKeyAgree_CheckedChanged);
            // 
            // tbCertFile
            // 
            this.tbCertFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCertFile.Location = new System.Drawing.Point(1111, 290);
            this.tbCertFile.Name = "tbCertFile";
            this.tbCertFile.Size = new System.Drawing.Size(248, 20);
            this.tbCertFile.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1111, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Алгоритм шифрования сессионного ключа:";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 624);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbCertFile);
            this.Controls.Add(this.rbKeyAgree);
            this.Controls.Add(this.rbKeyExchangeFormatter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbProviderPasswordSender);
            this.Controls.Add(this.cbProviderNameSender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProviderPassword);
            this.Controls.Add(this.cbProviderName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bMarkantClear);
            this.Controls.Add(this.bClearGost28147);
            this.Controls.Add(this.bCreateGost28147);
            this.Controls.Add(this.bDecrypt);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCurrentMarkant);
            this.Controls.Add(this.tbMarkantASN1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDecryptText);
            this.Controls.Add(this.tbEncryptText);
            this.Controls.Add(this.tbSourceText);
            this.Controls.Add(this.bDecryptMarkant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMarkantHex);
            this.Controls.Add(this.bCreateMarkant);
            this.Controls.Add(this.pGost28147Red);
            this.Controls.Add(this.pGost28147Green);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1287, 662);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Маркант КриптоПРО.NET";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCreateMarkant;
        private System.Windows.Forms.TextBox tbMarkantHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDecryptMarkant;
        private System.Windows.Forms.TextBox tbSourceText;
        private System.Windows.Forms.TextBox tbEncryptText;
        private System.Windows.Forms.TextBox tbDecryptText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMarkantASN1;
        private System.Windows.Forms.TextBox tbCurrentMarkant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Button bDecrypt;
        private System.Windows.Forms.Button bCreateGost28147;
        private System.Windows.Forms.Button bClearGost28147;
        private System.Windows.Forms.Button bMarkantClear;
        private System.Windows.Forms.Panel pGost28147Green;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pGost28147Red;
        private System.Windows.Forms.ComboBox cbProviderName;
        private System.Windows.Forms.ComboBox cbProviderPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProviderPasswordSender;
        private System.Windows.Forms.ComboBox cbProviderNameSender;
        private System.Windows.Forms.RadioButton rbKeyExchangeFormatter;
        private System.Windows.Forms.RadioButton rbKeyAgree;
        private System.Windows.Forms.TextBox tbCertFile;
        private System.Windows.Forms.Label label11;
    }
}

