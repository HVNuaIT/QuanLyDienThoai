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
    public partial class FormHangSX : Form
    {
        public FormHangSX()
        {
            InitializeComponent();
        }
        QLDienThoai db = new QLDienThoai();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.HangDTs.Where(s => s.IDHang.Contains(ma.ToString())).First();
            txtIDHang.Text = obj.IDHang;
            txtTenHang.Text = obj.TenHang;

        }

        private void FormHangSX_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangDT s = new HangDT();
            s.IDHang = txtIDHang.Text;
            s.TenHang = txtTenHang.Text;
            db.HangDTs.Add(s);
            db.SaveChanges();
            loadData();
            reset();

        }
        void loadData()
        {
            dataGridView1.DataSource = db.HangDTs.ToList();

        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtIDHang.Text.Trim();
            var s = db.HangDTs.Where(a => a.IDHang.Contains(ma)).First();
            s.IDHang = txtIDHang.Text;
            s.TenHang = txtTenHang.Text;
            db.SaveChanges();
            loadData();
            MessageBox.Show("Sửa Thành Công", "Thống Báo");
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String ma = txtIDHang.Text.Trim();
            var s = db.HangDTs.Where(a => a.IDHang.Contains(ma)).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.HangDTs.Remove(s);
            db.SaveChanges();
            loadData();
            reset();

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Form x = new FormTrangChu();
            DialogResult dt = MessageBox.Show("Bạn có muốn quay lại trang chủ không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            x.Show();
            this.Hide();
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            String ma = txttim.Text.Trim();
            dataGridView1.DataSource = db.HangDTs.Where(s => s.IDHang.Contains(ma)).ToList();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadData();
        }
        void reset()
        {
            txtIDHang.Text = String.Empty;
            txtTenHang.Text = String.Empty;
            txttim.Text = String.Empty;
        }
    }

}
