namespace QuanLyChuoiCH
{
    partial class MHChuamua
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
            this.dgvChuamua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuamua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChuamua
            // 
            this.dgvChuamua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuamua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuamua.Location = new System.Drawing.Point(0, 0);
            this.dgvChuamua.Name = "dgvChuamua";
            this.dgvChuamua.RowTemplate.Height = 24;
            this.dgvChuamua.Size = new System.Drawing.Size(553, 242);
            this.dgvChuamua.TabIndex = 0;
            // 
            // MHChuamua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 242);
            this.Controls.Add(this.dgvChuamua);
            this.Name = "MHChuamua";
            this.Text = "Mặt hàng chưa mua";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuamua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChuamua;
    }
}