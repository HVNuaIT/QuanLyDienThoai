using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDienThoai
{
    public partial class FormChiTiet : Form
    {
        public FormChiTiet()
        {
            InitializeComponent();
        }
        QLDienThoai db = new QLDienThoai();
        private void FormChiTiet_Load(object sender, EventArgs e)
        {
           
            loaddata();
            tacHT();
        }
        void loaddata()
        {
            List<DonHang> dsdh = db.DonHangs.ToList();
            cbMdh.DisplayMember = "IDDonHang";
            cbMdh.ValueMember = "IDDonHang";
            cbMdh.DataSource = dsdh;
        }
        void loaddataDsHD()
        {
           
            String hd = cbMdh.SelectedValue.ToString();
            var ds = db.DonHangs.Where(s => s.IDDonHang.Contains(hd)).First();
            txtGia.Text = ds.GiaBan.ToString();
            txtNgay.Text = ds.NgayBan.ToString();
            txtSoLuong.Text = ds.SoLuong.ToString();
            txtMaKhach.Text = ds.IdKhach;
            txtMaDT.Text = ds.IDDT;
            txtMaHang.Text = ds.IDHang;
            txtMaNV.Text = ds.IdUser.ToString();
            txtThanhTien.Text = ds.ThanhTien.ToString();

            String idKhach = txtMaKhach.Text;
            var dsKhach = db.KhachHangs.Where(s => s.IdKhach.Contains(idKhach)).First();
            txtTenKhach.Text = dsKhach.TenKhach;
            txtDC.Text = dsKhach.DiaChi;
            txtSDT.Text = dsKhach.SDT.ToString();
            int ma = Convert.ToInt32(txtMaNV.Text);
            var dsNV = db.Users.Where(s => s.IdUser == ma).First();
            txtTenNV.Text = dsNV.TenNguoiDung;
            String Hang = txtMaHang.Text;
            var dsHang = db.HangDTs.Where(s => s.IDHang.Contains(Hang)).First();
            txtTenHang.Text = dsHang.TenHang;
            String maDT = txtMaDT.Text;
            var dsDT = db.DienThoais.Where(s => s.IDDT.Contains(maDT)).First();
            txtTenDT.Text = dsDT.TenDT;
            MemoryStream mm = new MemoryStream(dsDT.HinhAnh.ToArray());
            Image img = Image.FromStream(mm);
            ptbHinh.Image = img;


        }
       void tacHT()
        {
            txtTenKhach.Enabled = false;
            txtDC.Enabled = false;
            txtSDT.Enabled = false;
            txtTenDT.Enabled = false;
            txtTenHang.Enabled = false;
            txtGia.Enabled = false;
            txtMaHang.Enabled = false;
            txtMaDT.Enabled = false;
            txtThanhTien.Enabled = false;
           
        }

        private void bntXem_Click(object sender, EventArgs e)
        { 
            String hd = cbMdh.SelectedValue.ToString();
            var ds = db.DonHangs.Where(s => s.IDDonHang.Contains(hd)).First();

           if (ds.IDDonHang == cbMdh.SelectedValue)
            {
                loaddataDsHD();
            }
           
        }

        private void btnQuayLại_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Muốn Quay Lại Đơn Hàng", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            Form x = new FormDonHang();
            x.Show();
            this.Hide();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenKhach.Text = String.Empty;
            txtDC.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTenDT.Text = String.Empty;
            txtTenHang.Text = String.Empty;
            txtGia.Text = String.Empty;
            txtSoLuong.Text = String.Empty;
            txtThanhTien.Text = String.Empty;
            txtMaHang.Text = String.Empty;
            cbMdh.Text = String.Empty;
            txtMaHang.Text = String.Empty;
            txtMaDT.Text = String.Empty;
            txtTenNV.Text = String.Empty;
            txtMaNV.Text = String.Empty;
            txtMaKhach.Text = String.Empty;
            txtNgay.Text = String.Empty;
            txtGG.Text = String.Empty;
        }

        private void bntThanhToán_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSoLuong.Text);
            float b = Convert.ToInt32(txtGia.Text);
            if (txtGG.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Giam Gía", "Thông Báo");
                return;
            }
            float c =  Convert.ToInt32(txtGG.Text);
            String ma = txtMaDT.Text;
            var ds = db.DienThoais.Where(x => x.IDDT == ma).First();
            if (ds.SoLuong <= 0)
            {
                MessageBox.Show("Đã Hết Hàng");
                return;
            }
           
            thanhtoan(a, b, c);
            ds.SoLuong -= Convert.ToInt32( txtSoLuong.Text);
            db.SaveChanges();
            MessageBox.Show("Thanh Tiền "+"Của Qúy Khách :" + txtTenKhach.Text +" \n Là:"+ txtThanhTien.Text , "Thông Báo");
        }
        void thanhtoan(int a , float b ,float c )
        {
            float kq = a * b ;
            float kqtiengiam = kq * (c / 100);
            float tongtien = kq - kqtiengiam;
            txtThanhTien.Text = tongtien.ToString();  
        }
        private void btnLưu_Click(object sender, EventArgs e)
        {
            var ds = db.DonHangs.Where(s => s.IDDonHang.Contains(cbMdh.SelectedValue.ToString())).First();
            ds.ThanhTien = Convert.ToDouble(txtThanhTien.Text);
            ds.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            
            db.SaveChanges();
            
        }

       
        
    }
}
