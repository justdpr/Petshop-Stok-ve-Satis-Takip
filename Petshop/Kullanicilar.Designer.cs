namespace Petshop
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            this.dgwKullanici = new System.Windows.Forms.DataGridView();
            this.dgkullaniciid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgkullaniciadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgyetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAra = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).BeginInit();
            this.grpAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwKullanici
            // 
            this.dgwKullanici.AllowUserToAddRows = false;
            this.dgwKullanici.AllowUserToDeleteRows = false;
            this.dgwKullanici.AllowUserToResizeColumns = false;
            this.dgwKullanici.AllowUserToResizeRows = false;
            this.dgwKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgkullaniciid,
            this.dgkullaniciadi,
            this.dgsifre,
            this.dgyetki});
            this.dgwKullanici.Location = new System.Drawing.Point(11, 12);
            this.dgwKullanici.MultiSelect = false;
            this.dgwKullanici.Name = "dgwKullanici";
            this.dgwKullanici.ReadOnly = true;
            this.dgwKullanici.RowHeadersVisible = false;
            this.dgwKullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKullanici.ShowCellErrors = false;
            this.dgwKullanici.ShowEditingIcon = false;
            this.dgwKullanici.ShowRowErrors = false;
            this.dgwKullanici.Size = new System.Drawing.Size(520, 209);
            this.dgwKullanici.TabIndex = 0;
            // 
            // dgkullaniciid
            // 
            this.dgkullaniciid.DataPropertyName = "kullaniciid";
            this.dgkullaniciid.HeaderText = "kullaniciid";
            this.dgkullaniciid.Name = "dgkullaniciid";
            this.dgkullaniciid.ReadOnly = true;
            this.dgkullaniciid.Visible = false;
            // 
            // dgkullaniciadi
            // 
            this.dgkullaniciadi.DataPropertyName = "kullaniciadi";
            this.dgkullaniciadi.FillWeight = 200F;
            this.dgkullaniciadi.HeaderText = "KULLANICI ADI";
            this.dgkullaniciadi.Name = "dgkullaniciadi";
            this.dgkullaniciadi.ReadOnly = true;
            this.dgkullaniciadi.Width = 200;
            // 
            // dgsifre
            // 
            this.dgsifre.DataPropertyName = "sifre";
            this.dgsifre.FillWeight = 200F;
            this.dgsifre.HeaderText = "ŞİFRE";
            this.dgsifre.Name = "dgsifre";
            this.dgsifre.ReadOnly = true;
            this.dgsifre.Width = 200;
            // 
            // dgyetki
            // 
            this.dgyetki.DataPropertyName = "yetki";
            this.dgyetki.HeaderText = "YETKİ";
            this.dgyetki.Name = "dgyetki";
            this.dgyetki.ReadOnly = true;
            // 
            // grpAra
            // 
            this.grpAra.Controls.Add(this.txtAra);
            this.grpAra.Controls.Add(this.label1);
            this.grpAra.Location = new System.Drawing.Point(293, 234);
            this.grpAra.Name = "grpAra";
            this.grpAra.Size = new System.Drawing.Size(227, 92);
            this.grpAra.TabIndex = 4;
            this.grpAra.TabStop = false;
            this.grpAra.Text = "Kullanıcı Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(25, 55);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(177, 22);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Image = global::Petshop.Properties.Resources.kullanicisil24;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(88, 291);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(65, 35);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuzenle.Image = global::Petshop.Properties.Resources.duzenle24;
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(148, 250);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 35);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Image = global::Petshop.Properties.Resources.ekle24;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(23, 250);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 338);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.grpAra);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwKullanici);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICILAR";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanici)).EndInit();
            this.grpAra.ResumeLayout(false);
            this.grpAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKullanici;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgkullaniciid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgkullaniciadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgyetki;
        private System.Windows.Forms.GroupBox grpAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}