namespace STP1083amp.View
{
    partial class frmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            groupBox1 = new GroupBox();
            grdPersoneller = new DataGridView();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            btnYeni = new Button();
            txtAdres = new RichTextBox();
            mskTelefon = new MaskedTextBox();
            txtMail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtKullanici = new TextBox();
            label6 = new Label();
            txtSifre = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdPersoneller).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtKullanici);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(grdPersoneller);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(mskTelefon);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 393);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİ GİRİŞİ";
            // 
            // grdPersoneller
            // 
            grdPersoneller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPersoneller.Location = new Point(7, 224);
            grdPersoneller.MultiSelect = false;
            grdPersoneller.Name = "grdPersoneller";
            grdPersoneller.RowTemplate.Height = 25;
            grdPersoneller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdPersoneller.Size = new Size(681, 163);
            grdPersoneller.TabIndex = 14;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(576, 165);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(111, 35);
            btnGuncelle.TabIndex = 13;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Image = (Image)resources.GetObject("btnSil.Image");
            btnSil.ImageAlign = ContentAlignment.MiddleRight;
            btnSil.Location = new Point(484, 165);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(86, 35);
            btnSil.TabIndex = 12;
            btnSil.Text = "SİL";
            btnSil.TextAlign = ContentAlignment.MiddleLeft;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnEkle.Location = new Point(385, 165);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 35);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            btnYeni.Image = (Image)resources.GetObject("btnYeni.Image");
            btnYeni.ImageAlign = ContentAlignment.MiddleRight;
            btnYeni.Location = new Point(7, 165);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(104, 36);
            btnYeni.TabIndex = 10;
            btnYeni.Text = "YENİ KAYIT";
            btnYeni.TextAlign = ContentAlignment.MiddleLeft;
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(552, 41);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(135, 61);
            txtAdres.TabIndex = 9;
            txtAdres.Text = "";
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(88, 79);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(148, 23);
            mskTelefon.TabIndex = 8;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(333, 79);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(138, 23);
            txtMail.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(333, 37);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(138, 23);
            txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(88, 37);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(145, 23);
            txtAd.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 40);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Adres : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 82);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Mail : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 40);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Soyad : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 82);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefon : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad : ";
            // 
            // txtKullanici
            // 
            txtKullanici.Location = new Point(88, 129);
            txtKullanici.Name = "txtKullanici";
            txtKullanici.Size = new Size(145, 23);
            txtKullanici.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 132);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 15;
            label6.Text = "Kullanıcı Adı : ";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(333, 124);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(138, 23);
            txtSifre.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 127);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 17;
            label7.Text = "Şifre : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(552, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(505, 132);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 20;
            label8.Text = "Yetki : ";
            // 
            // frmPersonelIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 429);
            Controls.Add(groupBox1);
            Name = "frmPersonelIslemleri";
            Text = "PERSONEL İŞLEMLERİ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdPersoneller).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSifre;
        private Label label7;
        private TextBox txtKullanici;
        private Label label6;
        private DataGridView grdPersoneller;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnYeni;
        private RichTextBox txtAdres;
        private MaskedTextBox mskTelefon;
        private TextBox txtMail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private ComboBox comboBox1;
    }
}