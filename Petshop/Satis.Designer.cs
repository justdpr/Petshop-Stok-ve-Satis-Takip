namespace Petshop
{
    partial class frmSatis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgwSepet = new System.Windows.Forms.DataGridView();
            this.dgbarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgstok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgurun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgurunadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOdenen = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).BeginInit();
            this.cmsSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmrAdet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnSepeteEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtStok);
            this.groupBox1.Controls.Add(this.txtUrun);
            this.groupBox1.Controls.Add(this.txtBarkod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(89, 60);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(118, 22);
            this.nmrAdet.TabIndex = 1;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Adet :";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSepeteEkle.Image = global::Petshop.Properties.Resources.sepeteekle32;
            this.btnSepeteEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSepeteEkle.Location = new System.Drawing.Point(214, 21);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(102, 64);
            this.btnSepeteEkle.TabIndex = 2;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "₺";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(213, 130);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(82, 22);
            this.txtFiyat.TabIndex = 7;
            // 
            // txtStok
            // 
            this.txtStok.Enabled = false;
            this.txtStok.Location = new System.Drawing.Point(70, 130);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(82, 22);
            this.txtStok.TabIndex = 6;
            // 
            // txtUrun
            // 
            this.txtUrun.Enabled = false;
            this.txtUrun.Location = new System.Drawing.Point(70, 93);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(246, 22);
            this.txtUrun.TabIndex = 5;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(89, 26);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(118, 22);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYeniMusteri);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtSoyadi);
            this.groupBox2.Controls.Add(this.txtAdi);
            this.groupBox2.Controls.Add(this.txtTc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(415, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniMusteri.Image = global::Petshop.Properties.Resources.yenimusteri32;
            this.btnYeniMusteri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnYeniMusteri.Location = new System.Drawing.Point(214, 44);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(75, 77);
            this.btnYeniMusteri.TabIndex = 1;
            this.btnYeniMusteri.Text = "Yeni\r\nMüşteri";
            this.btnYeniMusteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniMusteri.UseVisualStyleBackColor = true;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Enabled = false;
            this.txtTelefon.Location = new System.Drawing.Point(94, 134);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Enabled = false;
            this.txtSoyadi.Location = new System.Drawing.Point(94, 97);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txtSoyadi.TabIndex = 6;
            // 
            // txtAdi
            // 
            this.txtAdi.Enabled = false;
            this.txtAdi.Location = new System.Drawing.Point(94, 60);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 22);
            this.txtAdi.TabIndex = 5;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(94, 23);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telefon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Soyadı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "TC :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "SEPET";
            // 
            // dgwSepet
            // 
            this.dgwSepet.AllowUserToAddRows = false;
            this.dgwSepet.AllowUserToDeleteRows = false;
            this.dgwSepet.AllowUserToResizeColumns = false;
            this.dgwSepet.AllowUserToResizeRows = false;
            this.dgwSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbarkod,
            this.dgstok,
            this.dgadet,
            this.dgurun,
            this.dgurunadet,
            this.dgfiyat});
            this.dgwSepet.ContextMenuStrip = this.cmsSil;
            this.dgwSepet.Location = new System.Drawing.Point(19, 214);
            this.dgwSepet.MultiSelect = false;
            this.dgwSepet.Name = "dgwSepet";
            this.dgwSepet.ReadOnly = true;
            this.dgwSepet.RowHeadersVisible = false;
            this.dgwSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSepet.ShowCellErrors = false;
            this.dgwSepet.ShowEditingIcon = false;
            this.dgwSepet.ShowRowErrors = false;
            this.dgwSepet.Size = new System.Drawing.Size(520, 209);
            this.dgwSepet.TabIndex = 2;
            this.dgwSepet.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgwSepet_RowsAdded);
            // 
            // dgbarkod
            // 
            this.dgbarkod.HeaderText = "barkod";
            this.dgbarkod.Name = "dgbarkod";
            this.dgbarkod.ReadOnly = true;
            this.dgbarkod.Visible = false;
            // 
            // dgstok
            // 
            this.dgstok.HeaderText = "stok kod";
            this.dgstok.Name = "dgstok";
            this.dgstok.ReadOnly = true;
            this.dgstok.Visible = false;
            // 
            // dgadet
            // 
            this.dgadet.HeaderText = "stok adet";
            this.dgadet.Name = "dgadet";
            this.dgadet.ReadOnly = true;
            this.dgadet.Visible = false;
            // 
            // dgurun
            // 
            this.dgurun.FillWeight = 250F;
            this.dgurun.HeaderText = "ÜRÜN";
            this.dgurun.Name = "dgurun";
            this.dgurun.ReadOnly = true;
            this.dgurun.Width = 250;
            // 
            // dgurunadet
            // 
            this.dgurunadet.HeaderText = "ADET";
            this.dgurunadet.Name = "dgurunadet";
            this.dgurunadet.ReadOnly = true;
            // 
            // dgfiyat
            // 
            this.dgfiyat.FillWeight = 150F;
            this.dgfiyat.HeaderText = "FİYAT";
            this.dgfiyat.Name = "dgfiyat";
            this.dgfiyat.ReadOnly = true;
            this.dgfiyat.Width = 150;
            // 
            // cmsSil
            // 
            this.cmsSil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmSil});
            this.cmsSil.Name = "cmsSil";
            this.cmsSil.Size = new System.Drawing.Size(181, 48);
            // 
            // tmSil
            // 
            this.tmSil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tmSil.Image = global::Petshop.Properties.Resources.urunsil24;
            this.tmSil.Name = "tmSil";
            this.tmSil.Size = new System.Drawing.Size(180, 22);
            this.tmSil.Text = "SİL";
            this.tmSil.Click += new System.EventHandler(this.tmSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(591, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Toplam Tutar";
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Location = new System.Drawing.Point(568, 243);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(145, 22);
            this.txtToplam.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(719, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "₺";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatisYap.Image = global::Petshop.Properties.Resources.satisyap32;
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisYap.Location = new System.Drawing.Point(596, 357);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(95, 66);
            this.btnSatisYap.TabIndex = 4;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(719, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "₺";
            // 
            // txtOdenen
            // 
            this.txtOdenen.Location = new System.Drawing.Point(568, 316);
            this.txtOdenen.Name = "txtOdenen";
            this.txtOdenen.Size = new System.Drawing.Size(145, 22);
            this.txtOdenen.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(591, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Ödenen Tutar";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(752, 440);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtOdenen);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgwSepet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ YAP";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).EndInit();
            this.cmsSil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgwSepet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgstok;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgurun;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgurunadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfiyat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOdenen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip cmsSil;
        private System.Windows.Forms.ToolStripMenuItem tmSil;
    }
}