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
    public partial class Khachchuamua : Form
    {
        public Khachchuamua()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            HoadonBLL hdBLL = new HoadonBLL();
            DataTable dt = new DataTable();
            dt = hdBLL.KHChuamua();
            dgvKHChuamua.DataSource = dt;
        }
    }
}
