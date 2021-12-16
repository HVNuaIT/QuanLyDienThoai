using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLDienThoai.FormLogin;

namespace QLDienThoai
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormLogin();
            DialogResult dt = MessageBox.Show("Bạn có muốn Thoát trang chủ không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            x.Show();
            this.Hide();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            Phanquyen();
        }

        void Phanquyen()
        {
            if (KiemTra.check == false)
            {
               quanLyNhânViênToolStripMenuItem .Enabled = false;
            }
        }

        private void quanLyĐiênThoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormDienThoai();
            x.Show();
            this.Hide();
        }

        private void quanLyHangSanXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormHangSX();
            x.Show();
            this.Hide();
        }

        private void quanLyNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormNhanVien();
            x.Show();
            this.Hide();
        }

        private void thôngKêĐiênThoaiTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThongKeDienThoai();
            x.Show();
            this.Hide();
        }

       

        private void đơnHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormDonHang();
            x.Show();
            this.Hide();
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormKhachHang();
            x.Show();
            this.Hide();
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new FormThongKeDoanhThu();
            x.Show();
            this.Hide();
        }
    }
}
