
namespace QLDienThoai
{
    partial class FormThongKeDoanhThu
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
            this.bntThoát = new System.Windows.Forms.Button();
            this.bntQuayLại = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.Ngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntThoát
            // 
            this.bntThoát.Location = new System.Drawing.Point(527, 365);
            this.bntThoát.Name = "bntThoát";
            this.bntThoát.Size = new System.Drawing.Size(75, 23);
            this.bntThoát.TabIndex = 29;
            this.bntThoát.Text = "Thoát";
            this.bntThoát.UseVisualStyleBackColor = true;
            this.bntThoát.Click += new System.EventHandler(this.bntThoát_Click);
            // 
            // bntQuayLại
            // 
            this.bntQuayLại.Location = new System.Drawing.Point(360, 365);
            this.bntQuayLại.Name = "bntQuayLại";
            this.bntQuayLại.Size = new System.Drawing.Size(75, 23);
            this.bntQuayLại.TabIndex = 28;
            this.bntQuayLại.Text = "Quay Lại";
            this.bntQuayLại.UseVisualStyleBackColor = true;
            this.bntQuayLại.Click += new System.EventHandler(this.bntQuayLại_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // bntExcel
            // 
            this.bntExcel.Location = new System.Drawing.Point(86, 374);
            this.bntExcel.Name = "bntExcel";
            this.bntExcel.Size = new System.Drawing.Size(75, 23);
            this.bntExcel.TabIndex = 26;
            this.bntExcel.Text = "&Excel";
            this.bntExcel.UseVisualStyleBackColor = true;
            this.bntExcel.Click += new System.EventHandler(this.bntExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(143, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 165);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(499, 131);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 33;
            this.btnTim.Text = "Thống Kê";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Doanh Thu";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(241, 138);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(222, 20);
            this.txtDoanhThu.TabIndex = 34;
            // 
            // Ngay
            // 
            this.Ngay.Location = new System.Drawing.Point(241, 99);
            this.Ngay.Name = "Ngay";
            this.Ngay.Size = new System.Drawing.Size(222, 20);
            this.Ngay.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tháng Cần Thống Kê";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDDonHang";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ThanhTien";
            this.Column4.HeaderText = "Thành Tiền";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDHang";
            this.Column2.HeaderText = "Mã Hàng";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaBan";
            this.Column6.HeaderText = "Gía Hàng";
            this.Column6.Name = "Column6";
            // 
            // bntLamMoi
            // 
            this.bntLamMoi.Location = new System.Drawing.Point(228, 374);
            this.bntLamMoi.Name = "bntLamMoi";
            this.bntLamMoi.Size = new System.Drawing.Size(75, 23);
            this.bntLamMoi.TabIndex = 38;
            this.bntLamMoi.Text = "Làm Mới";
            this.bntLamMoi.UseVisualStyleBackColor = true;
            this.bntLamMoi.Click += new System.EventHandler(this.bntLamMoi_Click);
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntLamMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ngay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoanhThu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntThoát);
            this.Controls.Add(this.bntQuayLại);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntExcel);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "FormThongKeDienThoai";
            this.Load += new System.EventHandler(this.FormThongKeDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntThoát;
        private System.Windows.Forms.Button bntQuayLại;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntExcel;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.DateTimePicker Ngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button bntLamMoi;
    }
}