namespace Petshop
{
    partial class frmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.grpAra = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStokEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgbarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtanim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfirma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.grpAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AllowUserToAddRows = false;
            this.dgwUrunler.AllowUserToDeleteRows = false;
            this.dgwUrunler.AllowUserToResizeColumns = false;
            this.dgwUrunler.AllowUserToResizeRows = false;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbarkod,
            this.dgtanim,
            this.dgfirma,
            this.dgadet});
            this.dgwUrunler.Location = new System.Drawing.Point(12, 11);
            this.dgwUrunler.MultiSelect = false;
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.ReadOnly = true;
            this.dgwUrunler.RowHeadersVisible = false;
            this.dgwUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUrunler.ShowCellErrors = false;
            this.dgwUrunler.ShowEditingIcon = false;
            this.dgwUrunler.ShowRowErrors = false;
            this.dgwUrunler.Size = new System.Drawing.Size(629, 472);
            this.dgwUrunler.TabIndex = 0;
            // 
            // grpAra
            // 
            this.grpAra.Controls.Add(this.txtAra);
            this.grpAra.Controls.Add(this.label1);
            this.grpAra.Location = new System.Drawing.Point(404, 492);
            this.grpAra.Name = "grpAra";
            this.grpAra.Size = new System.Drawing.Size(227, 65);
            this.grpAra.TabIndex = 4;
            this.grpAra.TabStop = false;
            this.grpAra.Text = "Ürün Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(66, 28);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(151, 22);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün :";
            // 
            // btnStokEkle
            // 
            this.btnStokEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStokEkle.Image = global::Petshop.Properties.Resources.stokekle24;
            this.btnStokEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStokEkle.Location = new System.Drawing.Point(258, 509);
            this.btnStokEkle.Name = "btnStokEkle";
            this.btnStokEkle.Size = new System.Drawing.Size(110, 35);
            this.btnStokEkle.TabIndex = 3;
            this.btnStokEkle.Text = "Stok Ekle";
            this.btnStokEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStokEkle.UseVisualStyleBackColor = true;
            this.btnStokEkle.Click += new System.EventHandler(this.btnStokEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuzenle.Image = global::Petshop.Properties.Resources.duzenle24;
            this.btnDuzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDuzenle.Location = new System.Drawing.Point(129, 509);
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
            this.btnEkle.Location = new System.Drawing.Point(18, 509);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 35);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgbarkod
            // 
            this.dgbarkod.DataPropertyName = "barkod";
            this.dgbarkod.HeaderText = "barkod";
            this.dgbarkod.Name = "dgbarkod";
            this.dgbarkod.ReadOnly = true;
            this.dgbarkod.Visible = false;
            // 
            // dgtanim
            // 
            this.dgtanim.DataPropertyName = "tanim";
            this.dgtanim.FillWeight = 300F;
            this.dgtanim.HeaderText = "ÜRÜN";
            this.dgtanim.Name = "dgtanim";
            this.dgtanim.ReadOnly = true;
            this.dgtanim.Width = 300;
            // 
            // dgfirma
            // 
            this.dgfirma.DataPropertyName = "firma";
            this.dgfirma.FillWeight = 200F;
            this.dgfirma.HeaderText = "FİRMA";
            this.dgfirma.Name = "dgfirma";
            this.dgfirma.ReadOnly = true;
            this.dgfirma.Width = 200;
            // 
            // dgadet
            // 
            this.dgadet.DataPropertyName = "adet";
            this.dgadet.HeaderText = "STOK";
            this.dgadet.Name = "dgadet";
            this.dgadet.ReadOnly = true;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(652, 568);
            this.Controls.Add(this.grpAra);
            this.Controls.Add(this.btnStokEkle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwUrunler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.grpAra.ResumeLayout(false);
            this.grpAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnStokEkle;
        private System.Windows.Forms.GroupBox grpAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtanim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfirma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadet;
    }
}