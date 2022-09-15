namespace Petshop
{
    partial class frmOdenenBorclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdenenBorclar));
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwOdenenBorc = new System.Windows.Forms.DataGridView();
            this.OdenenMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdenenTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdenenBorc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMusteri
            // 
            this.txtMusteri.Enabled = false;
            this.txtMusteri.Location = new System.Drawing.Point(94, 26);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(352, 22);
            this.txtMusteri.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Müşteri :";
            // 
            // dgwOdenenBorc
            // 
            this.dgwOdenenBorc.AllowUserToAddRows = false;
            this.dgwOdenenBorc.AllowUserToDeleteRows = false;
            this.dgwOdenenBorc.AllowUserToResizeColumns = false;
            this.dgwOdenenBorc.AllowUserToResizeRows = false;
            this.dgwOdenenBorc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOdenenBorc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdenenMiktar,
            this.OdenenTarih});
            this.dgwOdenenBorc.Location = new System.Drawing.Point(26, 64);
            this.dgwOdenenBorc.MultiSelect = false;
            this.dgwOdenenBorc.Name = "dgwOdenenBorc";
            this.dgwOdenenBorc.ReadOnly = true;
            this.dgwOdenenBorc.RowHeadersVisible = false;
            this.dgwOdenenBorc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOdenenBorc.ShowCellErrors = false;
            this.dgwOdenenBorc.ShowEditingIcon = false;
            this.dgwOdenenBorc.ShowRowErrors = false;
            this.dgwOdenenBorc.Size = new System.Drawing.Size(420, 260);
            this.dgwOdenenBorc.TabIndex = 0;
            // 
            // OdenenMiktar
            // 
            this.OdenenMiktar.DataPropertyName = "miktar";
            this.OdenenMiktar.FillWeight = 200F;
            this.OdenenMiktar.HeaderText = "Ödenen Miktar";
            this.OdenenMiktar.Name = "OdenenMiktar";
            this.OdenenMiktar.ReadOnly = true;
            this.OdenenMiktar.Width = 200;
            // 
            // OdenenTarih
            // 
            this.OdenenTarih.DataPropertyName = "tarih";
            this.OdenenTarih.FillWeight = 200F;
            this.OdenenTarih.HeaderText = "Ödenen Tarih";
            this.OdenenTarih.Name = "OdenenTarih";
            this.OdenenTarih.ReadOnly = true;
            this.OdenenTarih.Width = 200;
            // 
            // frmOdenenBorclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(469, 351);
            this.Controls.Add(this.dgwOdenenBorc);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdenenBorclar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDENEN BORÇLAR";
            this.Load += new System.EventHandler(this.frmOdenenBorclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOdenenBorc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwOdenenBorc;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdenenMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdenenTarih;
    }
}