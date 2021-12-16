
namespace QLDienThoai
{
    partial class FormThongKeDienThoai
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
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntThoát = new System.Windows.Forms.Button();
            this.bntQuayLại = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntExcel = new System.Windows.Forms.Button();
            this.cbDT = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(487, 99);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Thống Kê";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Điện Thoại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 165);
            this.dataGridView1.TabIndex = 41;
            // 
            // bntThoát
            // 
            this.bntThoát.Location = new System.Drawing.Point(532, 365);
            this.bntThoát.Name = "bntThoát";
            this.bntThoát.Size = new System.Drawing.Size(75, 23);
            this.bntThoát.TabIndex = 40;
            this.bntThoát.Text = "Thoát";
            this.bntThoát.UseVisualStyleBackColor = true;
            // 
            // bntQuayLại
            // 
            this.bntQuayLại.Location = new System.Drawing.Point(324, 365);
            this.bntQuayLại.Name = "bntQuayLại";
            this.bntQuayLại.Size = new System.Drawing.Size(75, 23);
            this.bntQuayLại.TabIndex = 39;
            this.bntQuayLại.Text = "Quay Lại";
            this.bntQuayLại.UseVisualStyleBackColor = true;
            this.bntQuayLại.Click += new System.EventHandler(this.bntQuayLại_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Thống Kê Điện Thoại";
            // 
            // bntExcel
            // 
            this.bntExcel.Location = new System.Drawing.Point(207, 365);
            this.bntExcel.Name = "bntExcel";
            this.bntExcel.Size = new System.Drawing.Size(75, 23);
            this.bntExcel.TabIndex = 37;
            this.bntExcel.Text = "&Excel";
            this.bntExcel.UseVisualStyleBackColor = true;
            this.bntExcel.Click += new System.EventHandler(this.bntExcel_Click);
            // 
            // cbDT
            // 
            this.cbDT.FormattingEnabled = true;
            this.cbDT.Location = new System.Drawing.Point(324, 101);
            this.cbDT.Name = "cbDT";
            this.cbDT.Size = new System.Drawing.Size(121, 21);
            this.cbDT.TabIndex = 46;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(430, 365);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 47;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormThongKeDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cbDT);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bntThoát);
            this.Controls.Add(this.bntQuayLại);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntExcel);
            this.Name = "FormThongKeDienThoai";
            this.Text = "Làm Mới";
            this.Load += new System.EventHandler(this.FormThongKeDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bntThoát;
        private System.Windows.Forms.Button bntQuayLại;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntExcel;
        private System.Windows.Forms.ComboBox cbDT;
        private System.Windows.Forms.Button btnLamMoi;
      
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVBDataGridViewTextBoxColumn;
    }
}