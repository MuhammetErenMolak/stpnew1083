namespace STP1083amp.View
{
    partial class frmTedarikciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTedarikciIslemleri));
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirmaAdi = new TextBox();
            txtYetkiliAdi = new TextBox();
            txtMail = new TextBox();
            mskTelefon = new MaskedTextBox();
            txtAdres = new RichTextBox();
            btnYeni = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            grdTedarikciler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTedarikciler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdTedarikciler);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Controls.Add(txtAdres);
            groupBox1.Controls.Add(mskTelefon);
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(txtYetkiliAdi);
            groupBox1.Controls.Add(txtFirmaAdi);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(694, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİ GİRİŞİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Firma Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 95);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefon : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 40);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Yetkili Ad Soyad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 95);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Mail : ";
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
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(88, 37);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(145, 23);
            txtFirmaAdi.TabIndex = 5;
            // 
            // txtYetkiliAdi
            // 
            txtYetkiliAdi.Location = new Point(360, 37);
            txtYetkiliAdi.Name = "txtYetkiliAdi";
            txtYetkiliAdi.Size = new Size(138, 23);
            txtYetkiliAdi.TabIndex = 6;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(360, 92);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(138, 23);
            txtMail.TabIndex = 7;
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(88, 92);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(148, 23);
            mskTelefon.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(552, 41);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(135, 61);
            txtAdres.TabIndex = 9;
            txtAdres.Text = "";
            // 
            // btnYeni
            // 
            btnYeni.Image = (Image)resources.GetObject("btnYeni.Image");
            btnYeni.ImageAlign = ContentAlignment.MiddleRight;
            btnYeni.Location = new Point(15, 142);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(104, 36);
            btnYeni.TabIndex = 10;
            btnYeni.Text = "YENİ KAYIT";
            btnYeni.TextAlign = ContentAlignment.MiddleLeft;
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(576, 142);
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
            btnSil.Location = new Point(464, 142);
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
            btnEkle.Location = new Point(357, 142);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 35);
            btnEkle.TabIndex = 11;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // grdTedarikciler
            // 
            grdTedarikciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTedarikciler.Location = new Point(6, 205);
            grdTedarikciler.MultiSelect = false;
            grdTedarikciler.Name = "grdTedarikciler";
            grdTedarikciler.RowTemplate.Height = 25;
            grdTedarikciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdTedarikciler.Size = new Size(681, 136);
            grdTedarikciler.TabIndex = 14;
            // 
            // frmTedarikciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmTedarikciIslemleri";
            Text = "TEDARİKCİ İŞLEMLERİ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTedarikciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMail;
        private TextBox txtYetkiliAdi;
        private TextBox txtFirmaAdi;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox txtAdres;
        private MaskedTextBox mskTelefon;
        private Button btnYeni;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView grdTedarikciler;
    }
}