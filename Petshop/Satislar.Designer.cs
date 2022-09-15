namespace Petshop
{
    partial class frmSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
            this.dgwSatislar = new System.Windows.Forms.DataGridView();
            this.dgwSepet = new System.Windows.Forms.DataGridView();
            this.dgurun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgurunadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.chcBorc = new System.Windows.Forms.CheckBox();
            this.dtpOnce = new System.Windows.Forms.DateTimePicker();
            this.dtpSonra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgsepet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgsoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgborc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwSatisYapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSatislar
            // 
            this.dgwSatislar.AllowUserToAddRows = false;
            this.dgwSatislar.AllowUserToDeleteRows = false;
            this.dgwSatislar.AllowUserToResizeColumns = false;
            this.dgwSatislar.AllowUserToResizeRows = false;
            this.dgwSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSatislar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgsepet,
            this.dgtc,
            this.dgadi,
            this.dgsoyadi,
            this.dgtelefon,
            this.dgborc,
            this.dgtarih,
            this.dgwSatisYapan});
            this.dgwSatislar.Location = new System.Drawing.Point(13, 11);
            this.dgwSatislar.MultiSelect = false;
            this.dgwSatislar.Name = "dgwSatislar";
            this.dgwSatislar.ReadOnly = true;
            this.dgwSatislar.RowHeadersVisible = false;
            this.dgwSatislar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSatislar.ShowCellErrors = false;
            this.dgwSatislar.ShowEditingIcon = false;
            this.dgwSatislar.ShowRowErrors = false;
            this.dgwSatislar.Size = new System.Drawing.Size(940, 360);
            this.dgwSatislar.TabIndex = 0;
            this.dgwSatislar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSatislar_CellDoubleClick);
            // 
            // dgwSepet
            // 
            this.dgwSepet.AllowUserToAddRows = false;
            this.dgwSepet.AllowUserToDeleteRows = false;
            this.dgwSepet.AllowUserToResizeColumns = false;
            this.dgwSepet.AllowUserToResizeRows = false;
            this.dgwSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgurun,
            this.dgurunadet,
            this.dgfiyat});
            this.dgwSepet.Location = new System.Drawing.Point(13, 377);
            this.dgwSepet.MultiSelect = false;
            this.dgwSepet.Name = "dgwSepet";
            this.dgwSepet.ReadOnly = true;
            this.dgwSepet.RowHeadersVisible = false;
            this.dgwSepet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSepet.ShowCellErrors = false;
            this.dgwSepet.ShowEditingIcon = false;
            this.dgwSepet.ShowRowErrors = false;
            this.dgwSepet.Size = new System.Drawing.Size(520, 218);
            this.dgwSepet.TabIndex = 1;
            // 
            // dgurun
            // 
            this.dgurun.DataPropertyName = "tanim";
            this.dgurun.FillWeight = 250F;
            this.dgurun.HeaderText = "ÜRÜN";
            this.dgurun.Name = "dgurun";
            this.dgurun.ReadOnly = true;
            this.dgurun.Width = 250;
            // 
            // dgurunadet
            // 
            this.dgurunadet.DataPropertyName = "adet";
            this.dgurunadet.HeaderText = "ADET";
            this.dgurunadet.Name = "dgurunadet";
            this.dgurunadet.ReadOnly = true;
            // 
            // dgfiyat
            // 
            this.dgfiyat.DataPropertyName = "fiyat";
            this.dgfiyat.FillWeight = 150F;
            this.dgfiyat.HeaderText = "FİYAT";
            this.dgfiyat.Name = "dgfiyat";
            this.dgfiyat.ReadOnly = true;
            this.dgfiyat.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(736, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri TC";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(717, 409);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(120, 22);
            this.txtTc.TabIndex = 2;
            // 
            // chcBorc
            // 
            this.chcBorc.AutoSize = true;
            this.chcBorc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chcBorc.Location = new System.Drawing.Point(718, 441);
            this.chcBorc.Name = "chcBorc";
            this.chcBorc.Size = new System.Drawing.Size(118, 20);
            this.chcBorc.TabIndex = 3;
            this.chcBorc.Text = "Borcu Olanlar";
            this.chcBorc.UseVisualStyleBackColor = true;
            // 
            // dtpOnce
            // 
            this.dtpOnce.Location = new System.Drawing.Point(641, 488);
            this.dtpOnce.Name = "dtpOnce";
            this.dtpOnce.Size = new System.Drawing.Size(249, 22);
            this.dtpOnce.TabIndex = 4;
            // 
            // dtpSonra
            // 
            this.dtpSonra.Location = new System.Drawing.Point(641, 520);
            this.dtpSonra.Name = "dtpSonra";
            this.dtpSonra.Size = new System.Drawing.Size(249, 22);
            this.dtpSonra.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tarih";
            // 
            // btnAra
            // 
            this.btnAra.Image = global::Petshop.Properties.Resources.ara24;
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.Location = new System.Drawing.Point(739, 559);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(78, 35);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "ARA";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dgsepet
            // 
            this.dgsepet.DataPropertyName = "sepet";
            this.dgsepet.HeaderText = "sepet";
            this.dgsepet.Name = "dgsepet";
            this.dgsepet.ReadOnly = true;
            this.dgsepet.Visible = false;
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
            this.dgadi.FillWeight = 200F;
            this.dgadi.HeaderText = "ADI";
            this.dgadi.Name = "dgadi";
            this.dgadi.ReadOnly = true;
            this.dgadi.Width = 200;
            // 
            // dgsoyadi
            // 
            this.dgsoyadi.DataPropertyName = "soyadi";
            this.dgsoyadi.FillWeight = 170F;
            this.dgsoyadi.HeaderText = "SOYADI";
            this.dgsoyadi.Name = "dgsoyadi";
            this.dgsoyadi.ReadOnly = true;
            this.dgsoyadi.Width = 170;
            // 
            // dgtelefon
            // 
            this.dgtelefon.DataPropertyName = "telefon";
            this.dgtelefon.HeaderText = "TELEFON";
            this.dgtelefon.Name = "dgtelefon";
            this.dgtelefon.ReadOnly = true;
            // 
            // dgborc
            // 
            this.dgborc.DataPropertyName = "borc";
            this.dgborc.HeaderText = "BORÇ";
            this.dgborc.Name = "dgborc";
            this.dgborc.ReadOnly = true;
            // 
            // dgtarih
            // 
            this.dgtarih.DataPropertyName = "tarih";
            this.dgtarih.HeaderText = "TARİH";
            this.dgtarih.Name = "dgtarih";
            this.dgtarih.ReadOnly = true;
            // 
            // dgwSatisYapan
            // 
            this.dgwSatisYapan.DataPropertyName = "satisyapan";
            this.dgwSatisYapan.FillWeight = 150F;
            this.dgwSatisYapan.HeaderText = "SATIŞ YAPAN";
            this.dgwSatisYapan.Name = "dgwSatisYapan";
            this.dgwSatisYapan.ReadOnly = true;
            this.dgwSatisYapan.Width = 150;
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(965, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtpSonra);
            this.Controls.Add(this.dtpOnce);
            this.Controls.Add(this.chcBorc);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwSepet);
            this.Controls.Add(this.dgwSatislar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞLAR";
            this.Load += new System.EventHandler(this.frmSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSatislar;
        private System.Windows.Forms.DataGridView dgwSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgurun;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgurunadet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfiyat;
        private System.Windows.Forms.CheckBox chcBorc;
        private System.Windows.Forms.DateTimePicker dtpOnce;
        private System.Windows.Forms.DateTimePicker dtpSonra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgsoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgborc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgwSatisYapan;
    }
}