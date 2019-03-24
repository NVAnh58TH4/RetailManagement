using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiCH
{
    public partial class Soluongban : Form
    {
        public string data { get; set; }
        MathangBLL mhBLL;
        public Soluongban()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            mhBLL = new MathangBLL();
        }

        private void Soluongban_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = mhBLL.getSLBan(data);
            if (dt.Rows.Count > 0)
                dgvSLBan.DataSource = dt;
            else
            {
                this.Close();
                MessageBox.Show("Mặt hàng không có thông tin bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
