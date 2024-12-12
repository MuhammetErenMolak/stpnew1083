namespace STP1083amp.View
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            toolStripMenuItem2 = new MenuStrip();
            menuTedarikci = new ToolStripMenuItem();
            menuUrun = new ToolStripMenuItem();
            menuSatis = new ToolStripMenuItem();
            menuMusteri = new ToolStripMenuItem();
            menuPersonel = new ToolStripMenuItem();
            lblPersonelAdSoyad = new ToolStripTextBox();
            lblYetki = new ToolStripTextBox();
            groupBox1 = new GroupBox();
            grdUrunListesi = new DataGridView();
            groupBox2 = new GroupBox();
            label1 = new Label();
            mskTxtMusteriTelefon = new MaskedTextBox();
            label2 = new Label();
            txtMusteriAdSoyad = new TextBox();
            btnMusteriSec = new Button();
            label3 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            txtNot = new RichTextBox();
            label4 = new Label();
            btnSatisYap = new Button();
            label5 = new Label();
            txtGenelToplam = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            toolStripMenuItem2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUrunListesi).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Items.AddRange(new ToolStripItem[] { menuTedarikci, menuUrun, menuSatis, menuMusteri, menuPersonel, lblPersonelAdSoyad, lblYetki });
            toolStripMenuItem2.Location = new Point(0, 0);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(1011, 27);
            toolStripMenuItem2.TabIndex = 0;
            toolStripMenuItem2.Text = "toolStripMenuItem1";
            // 
            // menuTedarikci
            // 
            menuTedarikci.Name = "menuTedarikci";
            menuTedarikci.Size = new Size(131, 23);
            menuTedarikci.Text = "TEDARİKÇİ İŞLEMLERİ";
            // 
            // menuUrun
            // 
            menuUrun.Name = "menuUrun";
            menuUrun.Size = new Size(108, 23);
            menuUrun.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // menuSatis
            // 
            menuSatis.Name = "menuSatis";
            menuSatis.Size = new Size(107, 23);
            menuSatis.Text = "SATIŞ DETAYLARI";
            // 
            // menuMusteri
            // 
            menuMusteri.Name = "menuMusteri";
            menuMusteri.Size = new Size(123, 23);
            menuMusteri.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // menuPersonel
            // 
            menuPersonel.Name = "menuPersonel";
            menuPersonel.Size = new Size(132, 23);
            menuPersonel.Text = "PERSONEL İŞLEMLERİ";
            // 
            // lblPersonelAdSoyad
            // 
            lblPersonelAdSoyad.ForeColor = SystemColors.MenuHighlight;
            lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            lblPersonelAdSoyad.Size = new Size(100, 23);
            lblPersonelAdSoyad.Text = "Personel Adı";
            // 
            // lblYetki
            // 
            lblYetki.Name = "lblYetki";
            lblYetki.Size = new Size(100, 23);
            lblYetki.Text = "yetki";
            lblYetki.TextBoxTextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(15, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 413);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜRÜN LİSTESİ";
            // 
            // grdUrunListesi
            // 
            grdUrunListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUrunListesi.Location = new Point(21, 56);
            grdUrunListesi.MultiSelect = false;
            grdUrunListesi.Name = "grdUrunListesi";
            grdUrunListesi.RowTemplate.Height = 25;
            grdUrunListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdUrunListesi.Size = new Size(401, 385);
            grdUrunListesi.TabIndex = 15;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtGenelToplam);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnSatisYap);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNot);
            groupBox2.Controls.Add(btnSil);
            groupBox2.Controls.Add(btnEkle);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnMusteriSec);
            groupBox2.Controls.Add(txtMusteriAdSoyad);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(mskTxtMusteriTelefon);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(438, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(573, 406);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "SATIŞ İŞLEMİ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 35);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Telefon :";
            // 
            // mskTxtMusteriTelefon
            // 
            mskTxtMusteriTelefon.Location = new Point(188, 32);
            mskTxtMusteriTelefon.Mask = "(999) 000-0000";
            mskTxtMusteriTelefon.Name = "mskTxtMusteriTelefon";
            mskTxtMusteriTelefon.Size = new Size(118, 23);
            mskTxtMusteriTelefon.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 71);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Müşteri :";
            // 
            // txtMusteriAdSoyad
            // 
            txtMusteriAdSoyad.Location = new Point(187, 68);
            txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            txtMusteriAdSoyad.Size = new Size(119, 23);
            txtMusteriAdSoyad.TabIndex = 4;
            // 
            // btnMusteriSec
            // 
            btnMusteriSec.Location = new Point(312, 32);
            btnMusteriSec.Name = "btnMusteriSec";
            btnMusteriSec.Size = new Size(75, 23);
            btnMusteriSec.TabIndex = 5;
            btnMusteriSec.Text = "SEÇ";
            btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 118);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 6;
            label3.Text = "SATIŞI YAPILACAK ÜRÜNLER";
            // 
            // btnEkle
            // 
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.MiddleRight;
            btnEkle.Location = new Point(6, 190);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(62, 32);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.TextAlign = ContentAlignment.MiddleLeft;
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Image = (Image)resources.GetObject("btnSil.Image");
            btnSil.ImageAlign = ContentAlignment.MiddleLeft;
            btnSil.Location = new Point(6, 241);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(62, 32);
            btnSil.TabIndex = 8;
            btnSil.Text = "SİL";
            btnSil.TextAlign = ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = true;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(312, 305);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(227, 42);
            txtNot.TabIndex = 9;
            txtNot.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 319);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "NOT EKLE :";
            // 
            // btnSatisYap
            // 
            btnSatisYap.Image = (Image)resources.GetObject("btnSatisYap.Image");
            btnSatisYap.ImageAlign = ContentAlignment.MiddleRight;
            btnSatisYap.Location = new Point(256, 365);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(93, 32);
            btnSatisYap.TabIndex = 11;
            btnSatisYap.Text = "SATIŞ YAP";
            btnSatisYap.TextAlign = ContentAlignment.MiddleLeft;
            btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 374);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 12;
            label5.Text = "Genel Toplam :";
            // 
            // txtGenelToplam
            // 
            txtGenelToplam.Location = new Point(446, 371);
            txtGenelToplam.Name = "txtGenelToplam";
            txtGenelToplam.Size = new Size(58, 23);
            txtGenelToplam.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 374);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 14;
            label6.Text = "₺";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(74, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(493, 150);
            dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kod";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ürün Adı";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Miktar";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Birim Fiyat";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Toplam";
            Column5.Name = "Column5";
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(groupBox2);
            Controls.Add(grdUrunListesi);
            Controls.Add(groupBox1);
            Controls.Add(toolStripMenuItem2);
            MainMenuStrip = toolStripMenuItem2;
            Name = "frmAnaSayfa";
            Text = "STOK TAKİP PROGRAM";
            toolStripMenuItem2.ResumeLayout(false);
            toolStripMenuItem2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdUrunListesi).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip toolStripMenuItem2;
        private ToolStripMenuItem menuTedarikci;
        private ToolStripMenuItem menuUrun;
        private ToolStripMenuItem menuSatis;
        private ToolStripMenuItem menuMusteri;
        private ToolStripMenuItem menuPersonel;
        private ToolStripTextBox lblPersonelAdSoyad;
        private ToolStripTextBox lblYetki;
        private GroupBox groupBox1;
        private DataGridView grdUrunListesi;
        private GroupBox groupBox2;
        private Label label3;
        private Button btnMusteriSec;
        private TextBox txtMusteriAdSoyad;
        private Label label2;
        private MaskedTextBox mskTxtMusteriTelefon;
        private Label label1;
        private Button btnSil;
        private Button btnEkle;
        private Label label4;
        private RichTextBox txtNot;
        private Button btnSatisYap;
        private Label label6;
        private TextBox txtGenelToplam;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}