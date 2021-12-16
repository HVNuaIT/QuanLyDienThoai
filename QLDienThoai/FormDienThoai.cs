using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDienThoai
{
    public partial class FormDienThoai : Form
    {
        public FormDienThoai()
        {
            InitializeComponent();
        }

        QLDienThoai db = new QLDienThoai();
        private void FormDienThoai_Load(object sender, EventArgs e)
        {
            loadData();
 
        }
        private void bntThem_Click(object sender, EventArgs e)
        {

           
            byte[] b = parttoArray(this.Text);
            DienThoai s = new DienThoai();
            s.IDDT = txtMaDT.Text;
            s.TenDT = txtTenDT.Text;
            s.GiaBan = Convert.ToInt32(txtGiaDT.Text);
            s.GiaNhap = Convert.ToInt32(txtGíaNhapDT.Text);
            s.HinhAnh = b;
            s.IDHang = cbHang.SelectedValue.ToString();
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.DVB = txtDV.Text;
            db.DienThoais.Add(s);
            db.SaveChanges();
            loadData();
            reset();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            String ma = txtMaDT.Text;
            var s = db.DienThoais.Where(a => a.IDDT.Contains(ma)).First();
            MemoryStream stream = new MemoryStream();
            ptHinh.Image.Save(stream, ImageFormat.Jpeg);
            s.IDDT = txtMaDT.Text;
            s.TenDT = txtTenDT.Text;
            s.GiaBan = Convert.ToInt32(txtGiaDT.Text);
            s.GiaNhap = Convert.ToInt32(txtGíaNhapDT.Text);
            s.HinhAnh = stream.ToArray();
            s.IDHang = cbHang.SelectedValue.ToString();
            s.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            s.DVB = txtDV.Text;
            db.SaveChanges();
            MessageBox.Show("Đã Sửa Thành Công ", "Thông Báo");
            loadData();
            reset();
        }
        private void bntXoa_Click(object sender, EventArgs e)
        {
            String ma = txtMaDT.Text;
            var ds = db.DienThoais.Where(s => s.IDDT.Contains(ma)).First();
            DialogResult dt = MessageBox.Show("Bạn Có Muốn Xóa Không ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.No)
            {
                return;
            }
            db.DienThoais.Remove(ds);
            db.SaveChanges();
            loadData();
            reset();
        }
        private void bntQuayLai_Click(object sender, EventArgs e)
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
            String ma = txtTim.Text.Trim();
            dataGridView1.DataSource = db.DienThoais.Where(s => s.IDDT.Contains(ma)).ToList();
        }

        private void BntLamMoi_Click(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            dataGridView1.DataSource = db.DienThoais.ToList();
            List<HangDT> dsHang = db.HangDTs.ToList();
            cbHang.DisplayMember = "TenHang";
            cbHang.ValueMember = "IDHang";
            cbHang.DataSource = dsHang;
        }
        private void BntThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            PictureBox pt = new PictureBox();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ptHinh.Image = Image.FromFile(ofd.FileName);
                this.Text = ofd.FileName;
            }


        }
       
        byte [] parttoArray(String a)
        {
            return File.ReadAllBytes(a);
        }
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            var obj = db.DienThoais.Where(s => s.IDDT.Contains( ma.ToString())).First();
            txtMaDT.Text = obj.IDDT;
            txtTenDT.Text = obj.TenDT;
            txtDV.Text = obj.DVB;
            txtGiaDT.Text =  obj.GiaBan.ToString();
            txtGíaNhapDT.Text = obj.GiaNhap.ToString();
            txtSoLuong.Text = obj.SoLuong.ToString();
            
            MemoryStream mm = new MemoryStream(obj.HinhAnh.ToArray());
            Image img = Image.FromStream(mm);
            ptHinh.Image =img ;
        }

       void reset()
        {
            txtMaDT.Text = String.Empty;
            txtDV.Text = String.Empty;
            txtGiaDT.Text = String.Empty;
            txtGíaNhapDT.Text = String.Empty;
            txtMaDT.Text = String.Empty;
            txtSoLuong.Text = String.Empty;
            txtTenDT.Text = String.Empty;
            txtTim.Text = String.Empty;
            cbHang.Text = String.Empty;
            ptHinh.Image = null;

        }

    }

}
