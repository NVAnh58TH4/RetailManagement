namespace QuanLyChuoiCH
{
    partial class Soluongban
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
            this.dgvSLBan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSLBan
            // 
            this.dgvSLBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSLBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSLBan.Location = new System.Drawing.Point(0, 0);
            this.dgvSLBan.Name = "dgvSLBan";
            this.dgvSLBan.RowTemplate.Height = 24;
            this.dgvSLBan.Size = new System.Drawing.Size(672, 298);
            this.dgvSLBan.TabIndex = 0;
            // 
            // Soluongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 298);
            this.Controls.Add(this.dgvSLBan);
            this.Name = "Soluongban";
            this.Text = "Soluongban";
            this.Load += new System.EventHandler(this.Soluongban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSLBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSLBan;
    }
}