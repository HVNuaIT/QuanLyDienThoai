
namespace QLDienThoai
{
    partial class FormDienThoai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BntLamMoi = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.bntTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntQuayLai = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ptHinh = new System.Windows.Forms.PictureBox();
            this.BntThemHinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaDT = new System.Windows.Forms.TextBox();
            this.cbHang = new System.Windows.Forms.ComboBox();
            this.txtGíaNhapDT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.BntLamMoi);
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.bntTim);
            this.groupBox3.Location = new System.Drawing.Point(497, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 108);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nhập Từ Khóa Tìm Kiếm";
            // 
            // BntLamMoi
            // 
            this.BntLamMoi.Location = new System.Drawing.Point(45, 79);
            this.BntLamMoi.Name = "BntLamMoi";
            this.BntLamMoi.Size = new System.Drawing.Size(188, 23);
            this.BntLamMoi.TabIndex = 23;
            this.BntLamMoi.Text = "Làm Mới";
            this.BntLamMoi.UseVisualStyleBackColor = true;
            this.BntLamMoi.Click += new System.EventHandler(this.BntLamMoi_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(54, 37);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(100, 20);
            this.txtTim.TabIndex = 21;
            // 
            // bntTim
            // 
            this.bntTim.Location = new System.Drawing.Point(199, 34);
            this.bntTim.Name = "bntTim";
            this.bntTim.Size = new System.Drawing.Size(75, 23);
            this.bntTim.TabIndex = 22;
            this.bntTim.Text = "Tìm Kiếm";
            this.bntTim.UseVisualStyleBackColor = true;
            this.bntTim.Click += new System.EventHandler(this.bntTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntThem);
            this.groupBox2.Controls.Add(this.bntXoa);
            this.groupBox2.Controls.Add(this.bntQuayLai);
            this.groupBox2.Controls.Add(this.bntSua);
            this.groupBox2.Location = new System.Drawing.Point(497, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 91);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(6, 19);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 0;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(199, 19);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 17;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntQuayLai
            // 
            this.bntQuayLai.Location = new System.Drawing.Point(199, 62);
            this.bntQuayLai.Name = "bntQuayLai";
            this.bntQuayLai.Size = new System.Drawing.Size(75, 23);
            this.bntQuayLai.TabIndex = 21;
            this.bntQuayLai.Text = "Quay Lại Trang Chủ";
            this.bntQuayLai.UseVisualStyleBackColor = true;
            this.bntQuayLai.Click += new System.EventHandler(this.bntQuayLai_Click);
            // 
            // bntSua
            // 
            this.bntSua.Location = new System.Drawing.Point(6, 62);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 23);
            this.bntSua.TabIndex = 18;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.ptHinh);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.BntThemHinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaDT);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenDT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGiaDT);
            this.groupBox1.Controls.Add(this.cbHang);
            this.groupBox1.Controls.Add(this.txtGíaNhapDT);
            this.groupBox1.Location = new System.Drawing.Point(-1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 276);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // txtDV
            // 
            this.txtDV.Location = new System.Drawing.Point(335, 155);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(100, 20);
            this.txtDV.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Đơn Vị";
            // 
            // ptHinh
            // 
            this.ptHinh.Location = new System.Drawing.Point(93, 175);
            this.ptHinh.Name = "ptHinh";
            this.ptHinh.Size = new System.Drawing.Size(180, 92);
            this.ptHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptHinh.TabIndex = 23;
            this.ptHinh.TabStop = false;
            // 
            // BntThemHinh
            // 
            this.BntThemHinh.Location = new System.Drawing.Point(346, 209);
            this.BntThemHinh.Name = "BntThemHinh";
            this.BntThemHinh.Size = new System.Drawing.Size(75, 23);
            this.BntThemHinh.TabIndex = 22;
            this.BntThemHinh.Text = "Thêm";
            this.BntThemHinh.UseVisualStyleBackColor = true;
            this.BntThemHinh.Click += new System.EventHandler(this.BntThemHinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Điện Thoại";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(93, 49);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(100, 20);
            this.txtMaDT.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(334, 89);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gía Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gía Nhập ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hãng Điện Thoại";
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(93, 89);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(100, 20);
            this.txtTenDT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hình Ảnh";
            // 
            // txtGiaDT
            // 
            this.txtGiaDT.Location = new System.Drawing.Point(93, 128);
            this.txtGiaDT.Name = "txtGiaDT";
            this.txtGiaDT.Size = new System.Drawing.Size(100, 20);
            this.txtGiaDT.TabIndex = 9;
            // 
            // cbHang
            // 
            this.cbHang.FormattingEnabled = true;
            this.cbHang.Location = new System.Drawing.Point(334, 120);
            this.cbHang.Name = "cbHang";
            this.cbHang.Size = new System.Drawing.Size(100, 21);
            this.cbHang.TabIndex = 14;
            // 
            // txtGíaNhapDT
            // 
            this.txtGíaNhapDT.Location = new System.Drawing.Point(334, 48);
            this.txtGíaNhapDT.Name = "txtGíaNhapDT";
            this.txtGíaNhapDT.Size = new System.Drawing.Size(100, 20);
            this.txtGíaNhapDT.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 155);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(332, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Danh Sách Điện Thoại ";
            // 
            // FormDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDienThoai";
            this.Text = "FormDienThoai";
            this.Load += new System.EventHandler(this.FormDienThoai_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BntLamMoi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button bntTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntQuayLai;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiaDT;
        private System.Windows.Forms.ComboBox cbHang;
        private System.Windows.Forms.TextBox txtGíaNhapDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BntThemHinh;
        private System.Windows.Forms.PictureBox ptHinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Label label10;
    }
}