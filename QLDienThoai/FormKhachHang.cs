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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        QLDienThoai db = new QLDienThoai();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var obj = db.KhachHangs.Where(s => s.IdKhach == ma).First();
            txtMaKhach.Text = obj.IdKhach;
            txtSDT.Text = obj.SDT.ToString();
            txtTen.Text = obj.TenKhach;
            txtDC.Text = obj.DiaChi;

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = db.KhachHangs.ToList();
        }
        private void bntThem_Click(object sender, EventArgs e)
        {
            KhachHang s = new KhachHang();
            s.IdKhach = txtMaKhach.Text;
            s.DiaChi = txtDC.Text;
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.TenKhach = txtTen.Text;
            db.KhachHangs.Add(s);
            db.SaveChanges();
            loadData();
            MessageBox.Show("Thêm Thành Công ", "Thông Báo ");
            reset();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtMaKhach.Text;
            var ds = db.KhachHangs.Where(s => s.IdKhach.Equals(ma)).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.KhachHangs.Remove(ds);
            db.SaveChanges();
            loadData();
            reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtMaKhach.Text;
            var s = db.KhachHangs.Where(a => a.IdKhach.Equals(ma)).First();
            s.IdKhach = txtMaKhach.Text;
            s.DiaChi = txtDC.Text;
            s.SDT = Convert.ToInt32(txtSDT.Text);
            s.TenKhach = txtTen.Text;
            db.SaveChanges();
            loadData();
            MessageBox.Show("Sửa Thành Công ", "Thông Báo ");
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

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Muốn Làm Mới", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            loadData();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String ten = txtTim.Text.Trim();
            dataGridView1.DataSource = db.KhachHangs.Where(s => s.TenKhach.Contains(ten)).ToList();
           
        }
        void reset()
        {
            txtMaKhach.Text = String.Empty;
            txtSDT.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtDC.Text = String.Empty;
        }
    }

}
