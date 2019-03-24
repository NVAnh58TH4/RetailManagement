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
    public partial class Form1 : Form
    {
        NhanvienBLL nvBLL;
        CuahangBLL chBLL;
        KhachhangBLL khBLL;
        MathangBLL mhBLL;
        HoadonBLL hdBLL;
        ChitietHDBLL cthdBLL;

        public Form1()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            InitializeComponent();
            nvBLL = new NhanvienBLL();
            chBLL = new CuahangBLL();
            khBLL = new KhachhangBLL();
            mhBLL = new MathangBLL();
            hdBLL = new HoadonBLL();
            cthdBLL = new ChitietHDBLL();
        }

        public void ShowAllNV()
        {
            DataTable dt = nvBLL.getAllNV();
            dgvNV.DataSource = dt;
        }

        public void ShowAllCH()
        {
            DataTable dt = chBLL.getAllCH();
            dgvCH.DataSource = dt;
        }

        public void ShowAllKH()
        {
            DataTable dt = khBLL.getAllKH();
            dgvKH.DataSource = dt;
        }

        public void ShowAllMH()
        {
            DataTable dt = mhBLL.getAllMH();
            dgvMH.DataSource = dt;
        }

        public void ShowAllHD()
        {
            DataTable dt = hdBLL.getAllHD();
            dgvHD.DataSource = dt;
        }

        public void ShowAllCTHD()
        {
            DataTable dt = cthdBLL.getAllCTHD();
            dgvCTHD.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllNV();
            ShowAllCH();
            ShowAllCTHD();
            ShowAllHD();
            ShowAllKH();
            ShowAllMH();
        }
        // Kiem tra
        public bool CheckDataNV()
        {
            DateTime temp;
            if (string.IsNullOrEmpty(txtNV_MaNV.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNV_MaNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNV_TenNV.Text))
            {
                MessageBox.Show("Chưa nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNV_TenNV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNV_Ngaysinh.Text))
            {
                MessageBox.Show("Chưa nhập ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNV_Ngaysinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNV_Gioitinh.Text))
            {
                MessageBox.Show("Chưa nhập giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNV_Gioitinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNV_MaCH.Text))
            {
                MessageBox.Show("Chưa nhập mã cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNV_MaCH.Focus();
                return false;
            }
            if (!DateTime.TryParseExact(txtNV_Ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
            {
                MessageBox.Show("Ngày sinh không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNV_Ngaysinh.Focus();
                return false;
            }
            return true;
        }

        public bool CheckDataCH()
        {
            if (string.IsNullOrEmpty(txtCH_MaCH.Text))
            {
                MessageBox.Show("Chưa nhập mã cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCH_MaCH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCH_TenCH.Text))
            {
                MessageBox.Show("Chưa nhập tên cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCH_TenCH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCH_Diachi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCH_Diachi.Focus();
                return false;
            }
            return true;
        }

        public bool CheckDataKH()
        {
            if (string.IsNullOrEmpty(txtKH_MaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKH_MaKH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtKH_TenKH.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKH_TenKH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtKH_Diachi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKH_Diachi.Focus();
                return false;
            }
            return true;
        }

        public bool CheckDataMH()
        {
            if (string.IsNullOrEmpty(txtMH_MaH.Text))
            {
                MessageBox.Show("Chưa nhập mã mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMH_MaH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMH_TenH.Text))
            {
                MessageBox.Show("Chưa nhập tên mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMH_TenH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMH_Dvitinh.Text))
            {
                MessageBox.Show("Chưa nhập đơn vị tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMH_Dvitinh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMH_Gia.Text))
            {
                MessageBox.Show("Chưa nhập giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMH_Gia.Focus();
                return false;
            }
            return true;
        }

        public bool CheckDataHD()
        {
            DateTime temp;
            if (string.IsNullOrEmpty(txtHD_MaHD.Text))
            {
                MessageBox.Show("Chưa nhập mã hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHD_MaHD.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHD_MaKH.Text))
            {
                MessageBox.Show("Chưa nhập mã khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHD_MaKH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHD_MaCH.Text))
            {
                MessageBox.Show("Chưa nhập mã cửa hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHD_MaCH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHD_Ngaylap.Text))
            {
                MessageBox.Show("Chưa nhập ngày lập hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHD_Ngaylap.Focus();
                return false;
            }
            if (!DateTime.TryParseExact(txtHD_Ngaylap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out temp))
            {
                MessageBox.Show("Ngày tạo không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHD_Ngaylap.Focus();
                return false;
            }
            return true;
        }

        public bool CheckDataCTHD()
        {
            if (string.IsNullOrEmpty(txtCTHD_MaHD.Text))
            {
                MessageBox.Show("Chưa nhập mã hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCTHD_MaHD.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCTHD_MaH.Text))
            {
                MessageBox.Show("Chưa nhập mã mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCTHD_MaH.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCTHD_Soluong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCTHD_Soluong.Focus();
                return false;
            }
            return true;
        }
        //Functions

        //Nhan vien
        private void btnAdd_NV_Click(object sender, EventArgs e)
        {
            if (CheckDataNV())
            {
                Nhanvien nv = new Nhanvien();
                nv.MaNV = txtNV_MaNV.Text;
                nv.TenNV = txtNV_TenNV.Text;
                nv.NgaySinh = DateTime.ParseExact(txtNV_Ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nv.Gioitinh = txtNV_Gioitinh.Text;
                nv.MaCH = txtNV_MaCH.Text;

                if (nvBLL.insertNV(nv))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllNV();
                }
                else
                {

                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtNV_MaNV.Text = dgvNV.Rows[index].Cells["ColMaNV"].Value.ToString();
                txtNV_TenNV.Text = dgvNV.Rows[index].Cells["ColTenNV"].Value.ToString();
                txtNV_Gioitinh.Text = dgvNV.Rows[index].Cells["ColGioitinh"].Value.ToString();
                txtNV_MaCH.Text = dgvNV.Rows[index].Cells["ColMaCH"].Value.ToString();
                if (string.IsNullOrEmpty(dgvNV.Rows[index].Cells["ColNgaysinh"].Value.ToString()))
                {
                    txtNV_Ngaysinh.Text = null;
                }
                else
                {
                    DateTime date = (DateTime)dgvNV.Rows[index].Cells["ColNgaysinh"].Value;
                    txtNV_Ngaysinh.Text = date.ToString("dd/MM/yyyy");
                }
            }
        }

        private void btnEdit_NV_Click(object sender, EventArgs e)
        {
            if (CheckDataNV())
            {
                Nhanvien nv = new Nhanvien();
                nv.MaNV = txtNV_MaNV.Text;
                nv.TenNV = txtNV_TenNV.Text;
                nv.NgaySinh = DateTime.ParseExact(txtNV_Ngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nv.Gioitinh = txtNV_Gioitinh.Text;
                nv.MaCH = txtNV_MaCH.Text;

                if (nvBLL.updateNV(nv))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllNV();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_NV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Nhanvien nv = new Nhanvien();
                nv.MaNV = txtNV_MaNV.Text;

                if (nvBLL.deleteNV(nv))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllNV();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFindNV_TextChanged(object sender, EventArgs e)
        {
            string val = txtFindNV.Text;
            if (!string.IsNullOrEmpty(val))
            {
                DataTable dt = nvBLL.FindNV(val);
                dgvNV.DataSource = dt;
            }
            else
                ShowAllNV();
        }
        //Cua hang
        private void btnAdd_CH_Click(object sender, EventArgs e)
        {
            if (CheckDataCH())
            {
                Cuahang ch = new Cuahang();
                ch.MaCH = txtCH_MaCH.Text;
                ch.TenCH = txtCH_TenCH.Text;
                ch.Diachi = txtCH_Diachi.Text;

                if (chBLL.insertCH(ch))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtCH_MaCH.Text = dgvCH.Rows[index].Cells["ColMaCH_CH"].Value.ToString();
                txtCH_TenCH.Text = dgvCH.Rows[index].Cells["ColTenCH"].Value.ToString();
                txtCH_Diachi.Text = dgvCH.Rows[index].Cells["ColDiachiCH"].Value.ToString();
            }
        }

        private void btnEdit_CH_Click(object sender, EventArgs e)
        {
            if (CheckDataCH())
            {
                Cuahang ch = new Cuahang();
                ch.MaCH = txtCH_MaCH.Text;
                ch.TenCH = txtCH_TenCH.Text;
                ch.Diachi = txtCH_Diachi.Text;

                if (chBLL.updateCH(ch))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_CH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Cuahang ch = new Cuahang();
                ch.MaCH = txtCH_MaCH.Text;

                if (chBLL.deleteCH(ch))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Khach hang
        private void btnAdd_KH_Click(object sender, EventArgs e)
        {
            if (CheckDataKH())
            {
                Khachhang kh = new Khachhang();
                kh.MaKH = txtKH_MaKH.Text;
                kh.TenKH = txtKH_TenKH.Text;
                kh.Diachi = txtKH_Diachi.Text;

                if (khBLL.insertKH(kh))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllKH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_KH_Click(object sender, EventArgs e)
        {
            if (CheckDataKH())
            {
                Khachhang kh = new Khachhang();
                kh.MaKH = txtKH_MaKH.Text;
                kh.TenKH = txtKH_TenKH.Text;
                kh.Diachi = txtKH_Diachi.Text;

                if (khBLL.updateKH(kh))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllKH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtKH_MaKH.Text = dgvKH.Rows[index].Cells["ColMaKH_KH"].Value.ToString();
                txtKH_TenKH.Text = dgvKH.Rows[index].Cells["ColTenKH"].Value.ToString();
                txtKH_Diachi.Text = dgvKH.Rows[index].Cells["ColDiachiKH"].Value.ToString();
            }
        }

        private void btnDel_KH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Khachhang kh = new Khachhang();
                kh.MaKH = txtKH_MaKH.Text;

                if (khBLL.deleteKH(kh))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllKH();
                    ShowAllHD();
                    ShowAllCTHD();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Mat hang
        private void btnAdd_MH_Click(object sender, EventArgs e)
        {
            if (CheckDataMH())
            {
                Mathang mh = new Mathang();
                mh.MaH = txtMH_MaH.Text;
                mh.TenH = txtMH_TenH.Text;
                mh.Dvitinh = txtMH_Dvitinh.Text;
                mh.Gia = Int32.Parse(txtMH_Gia.Text);

                if (mhBLL.insertMH(mh))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllMH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_MH_Click(object sender, EventArgs e)
        {
            if (CheckDataMH())
            {
                Mathang mh = new Mathang();
                mh.MaH = txtMH_MaH.Text;
                mh.TenH = txtMH_TenH.Text;
                mh.Dvitinh = txtMH_Dvitinh.Text;
                mh.Gia = Int32.Parse(txtMH_Gia.Text);

                if (mhBLL.updateMH(mh))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllMH();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMH_MaH.Text = dgvMH.Rows[index].Cells["ColMaH_MH"].Value.ToString();
                txtMH_TenH.Text = dgvMH.Rows[index].Cells["ColTenH"].Value.ToString();
                txtMH_Dvitinh.Text = dgvMH.Rows[index].Cells["ColDvitinh"].Value.ToString();
                txtMH_Gia.Text = dgvMH.Rows[index].Cells["ColGia"].Value.ToString();
            }
        }

        private void btnDel_MH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Mathang mh = new Mathang();
                mh.MaH = txtMH_MaH.Text;

                if (mhBLL.deleteMH(mh))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllMH();
                    ShowAllCTHD();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hoa don
        private void btnAdd_HD_Click(object sender, EventArgs e)
        {
            if (CheckDataHD())
            {
                Hoadon hd = new Hoadon();
                hd.MaHD = txtHD_MaHD.Text;
                hd.MaKH = txtHD_MaKH.Text;
                hd.MaCH = txtHD_MaCH.Text;
                hd.Ngaylap = DateTime.ParseExact(txtHD_Ngaylap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (hdBLL.insertHD(hd))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllHD();
                }
                else
                {

                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_HD_Click(object sender, EventArgs e)
        {
            if (CheckDataHD())
            {
                Hoadon hd = new Hoadon();
                hd.MaHD = txtHD_MaHD.Text;
                hd.MaKH = txtHD_MaKH.Text;
                hd.MaCH = txtHD_MaCH.Text;
                hd.Ngaylap = DateTime.ParseExact(txtHD_Ngaylap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (hdBLL.insertHD(hd))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllHD();
                }
                else
                {

                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_HD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Hoadon hd = new Hoadon();
                hd.MaHD = txtHD_MaHD.Text;

                if (hdBLL.deleteHD(hd))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllHD();
                    ShowAllCTHD();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtHD_MaHD.Text = dgvHD.Rows[index].Cells["ColMaHD_HD"].Value.ToString();
                txtHD_MaKH.Text = dgvHD.Rows[index].Cells["ColMaKH_HD"].Value.ToString();
                txtHD_MaCH.Text = dgvHD.Rows[index].Cells["ColMaCH_HD"].Value.ToString();
                if (string.IsNullOrEmpty(dgvHD.Rows[index].Cells["ColNgaylap"].Value.ToString()))
                {
                    txtHD_Ngaylap.Text = null;
                }
                else
                {
                    DateTime date = (DateTime) dgvHD.Rows[index].Cells["ColNgaylap"].Value;
                    txtHD_Ngaylap.Text = date.ToString("dd/MM/yyyy");
                }
            }
        }

        // Chi tiet hoa don
        private void btnAdd_CTHD_Click(object sender, EventArgs e)
        {
            if (CheckDataCTHD())
            {
                ChitietHD cthd = new ChitietHD();
                cthd.MaHD = txtHD_MaHD.Text;
                cthd.MaH = txtCTHD_MaH.Text;
                cthd.Soluong = Int32.Parse(txtCTHD_Soluong.Text);

                if (cthdBLL.insertCTHD(cthd))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCTHD();
                }
                else
                {

                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_CTHD_Click(object sender, EventArgs e)
        {
            if (CheckDataCTHD())
            {
                ChitietHD cthd = new ChitietHD();
                cthd.MaHD = txtHD_MaHD.Text;
                cthd.MaH = txtCTHD_MaH.Text;
                cthd.Soluong = Int32.Parse(txtCTHD_Soluong.Text);

                if (cthdBLL.updateCTHD(cthd))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCTHD();
                }
                else
                {

                    MessageBox.Show("Có lỗi xảy ra, mời nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_CTHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ChitietHD cthd = new ChitietHD();
                cthd.MaHD = txtCTHD_MaHD.Text;

                if (cthdBLL.deleteCTHD(cthd))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCTHD();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtCTHD_MaHD.Text = dgvCTHD.Rows[index].Cells["ColMaHD_CTHD"].Value.ToString();
                txtCTHD_MaH.Text = dgvCTHD.Rows[index].Cells["ColMaH_CTHD"].Value.ToString();
                txtCTHD_Soluong.Text = dgvCTHD.Rows[index].Cells["ColSoluong_CTHD"].Value.ToString();
            }
        }

        private void btnThongke_CTHD_Click(object sender, EventArgs e)
        {
            Thongke tk = new Thongke();
            tk.Show();
        }

        private void btnChuamua_Click(object sender, EventArgs e)
        {
            MHChuamua wf = new MHChuamua();
            wf.Show();
        }

        private void btnKH_Chuamua_Click(object sender, EventArgs e)
        {
            Khachchuamua wf = new Khachchuamua();
            wf.Show();
        }

        private void btnSLBan_Click(object sender, EventArgs e)
        {
            Soluongban wf = new Soluongban();
            wf.data = txtMH_TenH.Text;
            wf.Show();
        }
    }
}