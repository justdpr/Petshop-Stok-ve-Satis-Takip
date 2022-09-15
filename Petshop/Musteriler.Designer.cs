namespace Petshop
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            this.dgwMusteriler = new System.Windows.Forms.DataGridView();
            this.dgtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgborc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAra = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdenenBorclar = new System.Windows.Forms.Button();
            this.btnBorcOde = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).BeginInit();
            this.grpAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMusteriler
            // 
            this.dgwMusteriler.AllowUserToAddRows = false;
            this.dgwMusteriler.AllowUserToDeleteRows = false;
            this.dgwMusteriler.AllowUserToResizeColumns = false;
            this.dgwMusteriler.AllowUserToResizeRows = false;
            this.dgwMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtc,
            this.dgadi,
            this.dgsoyadi,
            this.dgtelefon,
            this.dgadres,
            this.dgborc});
            this.dgwMusteriler.Location = new System.Drawing.Point(12, 12);
            this.dgwMusteriler.MultiSelect = false;
            this.dgwMusteriler.Name = "dgwMusteriler";
            this.dgwMusteriler.ReadOnly = true;
            this.dgwMusteriler.RowHeadersVisible = false;
            this.dgwMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMusteriler.ShowCellErrors = false;
            this.dgwMusteriler.ShowEditingIcon = false;
            this.dgwMusteriler.ShowRowErrors = false;
            this.dgwMusteriler.Size = new System.Drawing.Size(725, 444);
            this.dgwMusteriler.TabIndex = 0;
            // 
            // dgtc
            // 
            this.dgtc.DataPropertyName = "tc";
            this.dgtc.HeaderText = "TC";
            this.dgtc.Name = "dgtc";
            this.dgtc.ReadOnly = true;
            // 
            // dgadi
            // 
            this.dgadi.DataPropertyName = "adi";
            this.dgadi.FillWeight = 150F;
            this.dgadi.HeaderText = "ADI";
            this.dgadi.Name = "dgadi";
            this.dgadi.ReadOnly = true;
            this.dgadi.Width = 150;
            // 
            // dgsoyadi
            // 
            this.dgsoyadi.DataPropertyName = "soyadi";
            this.dgsoyadi.FillWeight = 150F;
            this.dgsoyadi.HeaderText = "SOYADI";
            this.dgsoyadi.Name = "dgsoyadi";
            this.dgsoyadi.ReadOnly = true;
            this.dgsoyadi.Width = 150;
            // 
            // dgtelefon
            // 
            this.dgtelefon.DataPropertyName = "telefon";
            this.dgtelefon.HeaderText = "TELEFON";
            this.dgtelefon.Name = "dgtelefon";
            this.dgtelefon.ReadOnly = true;
            // 
            // dgadres
            // 
            this.dgadres.DataPropertyName = "adres";
            this.dgadres.HeaderText = "ADRES";
            this.dgadres.Name = "dgadres";
            this.dgadres.ReadOnly = true;
            this.dgadres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgborc
            // 
            this.dgborc.DataPropertyName = "borc";
            this.dgborc.HeaderText = "BORÇ";
            this.dgborc.Name = "dgborc";
            this.dgborc.ReadOnly = true;
            // 
            // grpAra
            // 
            this.grpAra.Controls.Add(this.txtAra);
            this.grpAra.Controls.Add(this.label1);
            this.grpAra.Location = new System.Drawing.Point(545, 473);
            this.grpAra.Name = "grpAra";
            this.grpAra.Size = new System.Drawing.Size(192, 65);
            this.grpAra.TabIndex = 5;
            this.grpAra.TabStop = false;
            this.grpAra.Text = "Müşteri Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(54, 28);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(124, 22);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // btnOdenenBorclar
            // 
            this.btnOdenenBorclar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdenenBorclar.Image = global::Petshop.Properties.Resources.odenenborclar24;
            this.btnOdenenBorclar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdenenBorclar.Location = new System.Drawing.Point(376, 488);
            this.btnOdenenBorclar.Name = "btnOdenenBorclar";
            this.btnOdenenBorclar.Size = new System.Drawing.Size(153, 35);
            this.btnOdenenBorclar.TabIndex = 4;
            this.btnOdenenBorclar.Text = "Ödenen Borçlar";
            this.btnOdenenBorclar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdenenBorclar.UseVisualStyleBackColor = true;
            this.btnOdenenBorclar.Click += new System.EventHandler(this.btnOdenenBorclar_Click);
            // 
            // btnBorcOde
            // 
            this.btnBorcOde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorcOde.Image = global::Petshop.Properties.Resources.borcode24;
            this.btnBorcOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorcOde.Location = new System.Drawing.Point(241, 488);
            this.btnBorcOde.Name = "btnBorcOde";
            this.btnBorcOde.Size = new System.Drawing.Size(110, 35);
            this.btnBorcOde.TabIndex = 3;
            this.btnBorcOde.Text = "Borç Öde";
            this.btnBorcOde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorcOde.UseVisualStyleBackColor = true;
            this.btnBorcOde.Click += new System.EventHandler(this.btnBorcOde_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuzenle.Image = global::Petshop.Properties.Resources.duzenle24;
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(113, 488);
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
            this.btnEkle.Location = new System.Drawing.Point(12, 488);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(749, 550);
            this.Controls.Add(this.btnOdenenBorclar);
            this.Controls.Add(this.grpAra);
            this.Controls.Add(this.btnBorcOde);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwMusteriler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİLER";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriler)).EndInit();
            this.grpAra.ResumeLayout(false);
            this.grpAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusteriler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnBorcOde;
        private System.Windows.Forms.GroupBox grpAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgborc;
        private System.Windows.Forms.Button btnOdenenBorclar;
    }
}