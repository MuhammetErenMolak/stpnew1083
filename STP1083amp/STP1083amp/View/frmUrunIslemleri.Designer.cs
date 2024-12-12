namespace STP1083amp.View
{
    partial class frmUrunIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunIslemleri));
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtUrunAdi = new TextBox();
            label2 = new Label();
            txtAciklama = new RichTextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            cmbKategori = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            btnKategori = new Button();
            cmbTedarikci = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            btnYeni = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            grdUrunler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdUrunler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdUrunler);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(btnYeni);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbTedarikci);
            groupBox1.Controls.Add(btnKategori);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAciklama);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUrunAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİ GİRİŞİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(87, 39);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(147, 23);
            txtUrunAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 102);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(89, 99);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(145, 76);
            txtAciklama.TabIndex = 3;
            txtAciklama.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 42);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Kategori :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(339, 75);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(101, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(339, 39);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(131, 23);
            cmbKategori.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 77);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 7;
            label4.Text = "Stok Adedi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 42);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "Tedarikçi :";
            // 
            // btnKategori
            // 
            btnKategori.Location = new Point(476, 39);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(28, 23);
            btnKategori.TabIndex = 9;
            btnKategori.Text = "...";
            btnKategori.TextAlign = ContentAlignment.BottomCenter;
            btnKategori.UseVisualStyleBackColor = true;
            // 
            // cmbTedarikci
            // 
            cmbTedarikci.FormattingEnabled = true;
            cmbTedarikci.Location = new Point(582, 39);
            cmbTedarikci.Name = "cmbTedarikci";
            cmbTedarikci.Size = new Size(131, 23);
            cmbTedarikci.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 83);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Fiyatı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(649, 85);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 12;
            label7.Text = "₺";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(583, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 13;
            // 
            // btnYeni
            // 
            btnYeni.Image = (Image)resources.GetObject("btnYeni.Image");
            btnYeni.ImageAlign = ContentAlignment.MiddleRight;
            btnYeni.Location = new Point(249, 148);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(104, 36);
            btnYeni.TabIndex = 14;
            btnYeni.Text = "YENİ KAYIT";
            btnYeni.TextAlign = ContentAlignment.MiddleLeft;
            btnYeni.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.MiddleRight;
            btnGuncelle.Location = new Point(618, 149);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(111, 35);
            btnGuncelle.TabIndex = 17;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.TextAlign = ContentAlignment.MiddleLeft;
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Image = (Image)resources.GetObject("btnSil.Image");
            btnSil.ImageAlign = ContentAlignment.MiddleRight;
            btnSil.Location = new Point(526, 149);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(86, 35);
            btnSil.TabIndex = 16;
            btnSil.Text = "SİL";
            btnSil.TextAlign = ContentAlignment.MiddleLeft;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnEkle.Location = new Point(434, 148);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(86, 35);
            btnEkle.TabIndex = 15;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // grdUrunler
            // 
            grdUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUrunler.Location = new Point(6, 189);
            grdUrunler.MultiSelect = false;
            grdUrunler.Name = "grdUrunler";
            grdUrunler.RowTemplate.Height = 25;
            grdUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUrunler.Size = new Size(761, 136);
            grdUrunler.TabIndex = 18;
            // 
            // frmUrunIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmUrunIslemleri";
            Text = "ÜRÜN İŞLEMLERİ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdUrunler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private RichTextBox txtAciklama;
        private Label label2;
        private TextBox txtUrunAdi;
        private Label label1;
        private Label label4;
        private ComboBox cmbKategori;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Button btnKategori;
        private ComboBox cmbTedarikci;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Button btnYeni;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private DataGridView grdUrunler;
    }
}