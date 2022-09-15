namespace Petshop
{
    partial class frmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Petshop.Properties.Resources.dprLogo;
            this.pictureBox1.Location = new System.Drawing.Point(235, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Image = global::Petshop.Properties.Resources.cikis264;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.Location = new System.Drawing.Point(632, 311);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(130, 100);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKullanicilar.Image = global::Petshop.Properties.Resources.kullanicilar64;
            this.btnKullanicilar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullanicilar.Location = new System.Drawing.Point(632, 162);
            this.btnKullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(130, 100);
            this.btnKullanicilar.TabIndex = 4;
            this.btnKullanicilar.Text = "KULLANICILAR";
            this.btnKullanicilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnSatislar
            // 
            this.btnSatislar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatislar.Image = global::Petshop.Properties.Resources.satislar64;
            this.btnSatislar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatislar.Location = new System.Drawing.Point(632, 13);
            this.btnSatislar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(130, 100);
            this.btnSatislar.TabIndex = 3;
            this.btnSatislar.Text = "SATIŞLAR";
            this.btnSatislar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatislar.UseVisualStyleBackColor = true;
            this.btnSatislar.Click += new System.EventHandler(this.btnSatislar_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriler.Image = global::Petshop.Properties.Resources.musteriler64;
            this.btnMusteriler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriler.Location = new System.Drawing.Point(23, 162);
            this.btnMusteriler.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(130, 100);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "MÜŞTERİLER";
            this.btnMusteriler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.Ivory;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSatisYap.Image = global::Petshop.Properties.Resources.satisyap64;
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatisYap.Location = new System.Drawing.Point(23, 13);
            this.btnSatisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(130, 100);
            this.btnSatisYap.TabIndex = 0;
            this.btnSatisYap.Text = "SATIŞ YAP";
            this.btnSatisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUrunler.Image = global::Petshop.Properties.Resources.urunler64;
            this.btnUrunler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunler.Location = new System.Drawing.Point(23, 311);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(130, 100);
            this.btnUrunler.TabIndex = 2;
            this.btnUrunler.Text = "ÜRÜNLER";
            this.btnUrunler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKullanicilar);
            this.Controls.Add(this.btnSatislar);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnUrunler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dpR SATIŞ VE STOK TAKİP";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

