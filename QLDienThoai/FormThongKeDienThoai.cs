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
    public partial class FormThongKeDienThoai : Form
    {
        public FormThongKeDienThoai()
        {
            InitializeComponent();
        }
        QLDienThoai db = new QLDienThoai();
        private void FormThongKeDienThoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            String ma =  cbDT.SelectedValue.ToString();
            dataGridView1.DataSource = db.DienThoais.Where(d => d.IDHang.Contains(ma)).
                Select(t => new { t.IDDT, t.TenDT, t.GiaBan, t.GiaNhap, t.SoLuong }).
                ToList();
        }
        void LoadData()
        {
            dataGridView1.DataSource = db.DienThoais.Select(t => new { t.IDDT, t.TenDT,t.GiaBan,t.GiaNhap,t.SoLuong}).ToList();
            List<HangDT> dsHang = db.HangDTs.ToList();
            cbDT.DisplayMember = "TenHang";
            cbDT.ValueMember = "IDHang";
            cbDT.DataSource = dsHang;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bntQuayLại_Click(object sender, EventArgs e)
        {
            Form x = new FormTrangChu();
            x.Show();
            this.Hide();
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
    
    }
}
