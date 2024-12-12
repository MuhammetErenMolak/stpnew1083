namespace STP1083amp.View
{
    partial class frmSatisDetaylari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisDetaylari));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grdSatilanUrunler = new DataGridView();
            label1 = new Label();
            grdSatislar = new DataGridView();
            btnSatisIptal = new Button();
            txtSatisToplam = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSatilanUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdSatislar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdSatilanUrunler);
            groupBox1.Location = new Point(7, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SATIŞ LİSTESİ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSatisToplam);
            groupBox2.Controls.Add(btnSatisIptal);
            groupBox2.Controls.Add(grdSatislar);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(436, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(396, 283);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "SATIŞ DETAYLARI";
            // 
            // grdSatilanUrunler
            // 
            grdSatilanUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSatilanUrunler.Dock = DockStyle.Fill;
            grdSatilanUrunler.Location = new Point(3, 19);
            grdSatilanUrunler.MultiSelect = false;
            grdSatilanUrunler.Name = "grdSatilanUrunler";
            grdSatilanUrunler.RowTemplate.Height = 25;
            grdSatilanUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSatilanUrunler.Size = new Size(417, 275);
            grdSatilanUrunler.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 52);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "SATILAN ÜRÜNLER";
            // 
            // grdSatislar
            // 
            grdSatislar.AllowUserToAddRows = false;
            grdSatislar.AllowUserToDeleteRows = false;
            grdSatislar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdSatislar.Location = new Point(16, 97);
            grdSatislar.MultiSelect = false;
            grdSatislar.Name = "grdSatislar";
            grdSatislar.RowTemplate.Height = 25;
            grdSatislar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSatislar.Size = new Size(367, 95);
            grdSatislar.TabIndex = 16;
            // 
            // btnSatisIptal
            // 
            btnSatisIptal.Image = (Image)resources.GetObject("btnSatisIptal.Image");
            btnSatisIptal.ImageAlign = ContentAlignment.MiddleRight;
            btnSatisIptal.Location = new Point(11, 210);
            btnSatisIptal.Name = "btnSatisIptal";
            btnSatisIptal.Size = new Size(145, 39);
            btnSatisIptal.TabIndex = 17;
            btnSatisIptal.Text = "SATIŞI İPTAL ET";
            btnSatisIptal.TextAlign = ContentAlignment.MiddleLeft;
            btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // txtSatisToplam
            // 
            txtSatisToplam.Location = new Point(272, 219);
            txtSatisToplam.Name = "txtSatisToplam";
            txtSatisToplam.Size = new Size(100, 23);
            txtSatisToplam.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 222);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 19;
            label2.Text = "Satış Toplam Fiyatı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 222);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 20;
            label3.Text = "₺";
            // 
            // frmSatisDetaylari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 323);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSatisDetaylari";
            Text = "frmSatisDetaylari";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdSatilanUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdSatislar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView grdSatilanUrunler;
        private DataGridView grdSatislar;
        private Label label1;
        private Button btnSatisIptal;
        private Label label2;
        private TextBox txtSatisToplam;
        private Label label3;
    }
}