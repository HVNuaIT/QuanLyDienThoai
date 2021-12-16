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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        QLDienThoai db = new QLDienThoai();
        private void CMK_CheckedChanged(object sender, EventArgs e)
        {
            if (CMK.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = db.Users.Where(x => x.TaiKhoan == txtTK.Text).First();


                if (ds.TaiKhoan == txtTK.Text && ds.MatKhau == txtMK.Text)
                {
                    if (ds.IdChucVu == 1)
                    {
                        MessageBox.Show("Chúc Mừng Đã Đăng Nhập Thành Công Với Quyền Admin !!");
                        Form admin = new FormTrangChu();
                        admin.Show();
                        KiemTra.check = true;
                       
                       
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Chúc Mừng Đã Đăng Nhập Thành Công Quyền User !!");
                        Form nv = new FormTrangChu();
                        KiemTra.check = false;
                       
                       
                        nv.Show();
                        this.Hide();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng Nhập Thất Bại Rồi !!");
            }
        }
        public static class KiemTra
        {
            public static bool check { get; set; } = true;
           
        }
        
          

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Có Muốn Thoát Khỏi Chương Trình Không ?", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form x = new FormDangKi();
            x.Show();
            this.Hide();
        }
    }
}
