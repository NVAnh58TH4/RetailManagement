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
    public partial class MHChuamua : Form
    {
        public MHChuamua()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            ChitietHDBLL cthdBLL = new ChitietHDBLL();
            DataTable dt = new DataTable();
            dt = cthdBLL.MHchuamua();
            dgvChuamua.DataSource = dt;
        }
    }
}
