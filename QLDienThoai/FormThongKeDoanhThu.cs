using ClosedXML.Excel;
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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void bntExcel_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }

        }
        private void bntQuayLại_Click(object sender, EventArgs e)
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

        private void bntThoát_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ban Có Muốn Thoát Chương Trình ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormThongKeDienThoai_Load(object sender, EventArgs e)
        {
            load();

        }
        QLDienThoai db = new QLDienThoai();
        void load()
        {
            dataGridView1.DataSource = db.DonHangs.ToList();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime a = Ngay.Value;
            var ds = db.DonHangs.Where(s => s.NgayBan.Value.Month == a.Month).ToList();
            dataGridView1.DataSource = ds;
            var dsDH = db.DonHangs.Where(s => s.NgayBan.Value.Month == a.Month).Select(s => s.ThanhTien);
            double kq = (double)dsDH.Sum();
            txtDoanhThu.Text = kq.ToString();

        }
        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}

