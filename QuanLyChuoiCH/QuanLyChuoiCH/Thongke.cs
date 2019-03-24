using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuoiCH
{
    public partial class Thongke : Form
    {
        ChitietHDBLL cthdBLL;
        public Thongke()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            cthdBLL = new ChitietHDBLL();
            DataTable dt = new DataTable();
            dt = cthdBLL.thongkeCTHD();
            dgvThongke.DataSource = dt;
        }
    }
}
