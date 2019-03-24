namespace QuanLyChuoiCH
{
    partial class Khachchuamua
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
            this.dgvKHChuamua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHChuamua)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKHChuamua
            // 
            this.dgvKHChuamua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHChuamua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKHChuamua.Location = new System.Drawing.Point(0, 0);
            this.dgvKHChuamua.Name = "dgvKHChuamua";
            this.dgvKHChuamua.RowTemplate.Height = 24;
            this.dgvKHChuamua.Size = new System.Drawing.Size(419, 315);
            this.dgvKHChuamua.TabIndex = 0;
            // 
            // Khachchuamua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 315);
            this.Controls.Add(this.dgvKHChuamua);
            this.Name = "Khachchuamua";
            this.Text = "Khách chưa mua";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHChuamua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKHChuamua;
    }
}