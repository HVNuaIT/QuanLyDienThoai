using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDienThoai
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }
        QLDienThoai db = new QLDienThoai();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var obj = db.DonHangs.Where(s => s.IDDonHang == ma).First();
            txtMaDH.Text = obj.IDDonHang;
            txtGia.Text = obj.GiaBan.ToString();
            txtNgay.Text = obj.NgayBan.ToString();
            txtSoLuong.Text = obj.SoLuong.ToString();
            cbKhach.SelectedValue = obj.IdKhach;
            txtThanhTien.Text = obj.ThanhTien.ToString();
            cbHang.SelectedValue = obj.IDHang;
            cbNV.SelectedValue = obj.IdUser;
            cbTenDT.SelectedValue = obj.IDDT;

        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
                loadData();
                txtThanhTien.Enabled = false;
                txtGia.Enabled = false;
        }
        void loadData()
        {
            reset();
            var ds  = db.DonHangs.ToList();
            dataGridView1.DataSource = ds;
            List<DienThoai> dsDT = db.DienThoais.ToList();
            cbTenDT.Text = string.Empty;
            cbTenDT.DisplayMember = "TenDT";
            cbTenDT.ValueMember = "IDDT";
            cbTenDT.DataSource = dsDT;
            List<HangDT> dshang = db.HangDTs.ToList();
            cbHang.DisplayMember = "TenHang";
            cbHang.ValueMember = "IDHang";
            cbHang.DataSource = dshang;
            List<User> dsUser = db.Users.ToList();
            cbNV.DisplayMember = "TenNguoiDung";
            cbNV.ValueMember = "IdUser";
            cbNV.DataSource = dsUser;
            List<KhachHang> dsKhach = db.KhachHangs.ToList();
            cbKhach.DisplayMember = "TenKhach";
            cbKhach.ValueMember = "IdKhach";
            cbKhach.DataSource = dsKhach;


            var dsa = db.DienThoais.Where(c => c.IDDT == cbTenDT.SelectedValue).First();

            if (dsa.IDDT == cbTenDT.SelectedValue)
            {
                txtGia.Text = dsa.GiaBan.ToString();
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
           
            DonHang s = new DonHang();
            s.IDDonHang = txtMaDH.Text;
            s.IDDT = cbTenDT.SelectedValue.ToString();
            s.IDHang = cbHang.SelectedValue.ToString();
            s.IdUser = Convert.ToInt32( cbNV.SelectedValue);
            s.NgayBan = txtNgay.Value;
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.IdKhach = cbKhach.SelectedValue.ToString();
            s.GiaBan = Convert.ToInt32(txtGia.Text);
            s.ThanhTien = Convert.ToInt32(txtThanhTien.Text);
            db.DonHangs.Add(s);
            db.SaveChanges();
            loadData();
            reset();
        }
        void thanhToan(int a , float b ) 
        {
           
            float kq = a * b;
            txtThanhTien.Text = kq.ToString();
             
        }
        private void btnXN_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoLuong.Text);
            float b = Convert.ToInt32(txtGia.Text);
            String ma = cbTenDT.SelectedValue.ToString();
            var ds = db.DienThoais.Where(x => x.IDDT == ma).First();
            if (ds.SoLuong <= 0)
            {
                MessageBox.Show("Đã Hết Hàng");
                return;
            }
            thanhToan(a, b);
            
            db.SaveChanges();

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtMaDH.Text;
            var s = db.DonHangs.Where(g=> g.IDDonHang.Contains(ma)).First();
            float a = Convert.ToInt32(txtGia.Text);
            int b = Convert.ToInt32(txtSoLuong.Text);
            s.IDDonHang = txtMaDH.Text;
            s.IDDT = cbTenDT.SelectedValue.ToString();
            s.IDHang = cbHang.SelectedValue.ToString();
            s.IdUser = Convert.ToInt32(cbNV.SelectedValue);
            s.NgayBan = txtNgay.Value;
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.IdKhach = cbKhach.SelectedValue.ToString();
            var dsa = db.DienThoais.Where(c => c.IDDT == cbTenDT.SelectedValue).First();

            if (dsa.IDDT == cbTenDT.SelectedValue)
            {
                txtGia.Text = dsa.GiaBan.ToString();

            }
            s.GiaBan = Convert.ToInt32(txtGia.Text);
            s.ThanhTien = a * b;
            db.SaveChanges();
            loadData();
            MessageBox.Show("Sửa Thành Công ", "Thông Báo");
            reset();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtMaDH.Text;
            var ds = db.DonHangs.Where(s => s.IDDonHang.Contains(ma)).First();
            DialogResult dt = MessageBox.Show("Ban Muốn Xóa Hay Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.DonHangs.Remove(ds);
            db.SaveChanges();
            loadData();
            reset();

        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Muốn Quay Lại Trang Chủ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            Form x = new FormTrangChu();
            x.Show();
            this.Hide();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String ma = txtTim.Text.Trim();
            dataGridView1.DataSource = db.DonHangs.Where(s => s.IDDonHang.Contains(ma)).ToList();
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Muốn Làm Mới", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dt == DialogResult.No)
            {
                return;
            }
            loadData();
           
        }

        private void bntCT_Click(object sender, EventArgs e)
        {
            Form x = new FormChiTiet();
            x.Show();
            this.Hide();
        }
        void reset()
        {
            txtMaDH.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtNgay.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtThanhTien.Text = string.Empty;
            cbHang.Text = string.Empty;
            cbKhach.Text= string.Empty;
            cbNV.Text= string.Empty;
            cbTenDT.Text= string.Empty;
        }

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            var dsa = db.DienThoais.Where(c => c.IDDT == cbTenDT.SelectedValue).First();

            if (dsa.IDDT == cbTenDT.SelectedValue)
            {
                txtGia.Text = dsa.GiaBan.ToString();
            }
        }
    }

       
    }

