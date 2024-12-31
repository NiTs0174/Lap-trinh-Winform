namespace GUI

{
    partial class frmQLCT
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
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbViTri = new System.Windows.Forms.ComboBox();
            this.cmbTenDB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.lblMaTranDau = new System.Windows.Forms.Label();
            this.lblSoBanThang = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQuanLiCauThu = new System.Windows.Forms.DataGridView();
            this.grbTimKiem.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiCauThu)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtTK);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grbTimKiem.Location = new System.Drawing.Point(407, 123);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Size = new System.Drawing.Size(317, 75);
            this.grbTimKiem.TabIndex = 63;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(120, 33);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(190, 27);
            this.txtTK.TabIndex = 52;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Cầu Thủ";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.grbTimKiem);
            this.grbThongTin.Controls.Add(this.dateTimeNgaySinh);
            this.grbThongTin.Controls.Add(this.txtNoiSinh);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.cmbViTri);
            this.grbThongTin.Controls.Add(this.cmbTenDB);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.txtMaCT);
            this.grbThongTin.Controls.Add(this.txtTenCT);
            this.grbThongTin.Controls.Add(this.lblMaTranDau);
            this.grbThongTin.Controls.Add(this.lblSoBanThang);
            this.grbThongTin.Controls.Add(this.lblKetQua);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.ForeColor = System.Drawing.Color.Red;
            this.grbThongTin.Location = new System.Drawing.Point(0, 0);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Size = new System.Drawing.Size(744, 210);
            this.grbThongTin.TabIndex = 62;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(141, 117);
            this.dateTimeNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(231, 27);
            this.dateTimeNgaySinh.TabIndex = 57;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiSinh.Location = new System.Drawing.Point(141, 148);
            this.txtNoiSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(228, 27);
            this.txtNoiSinh.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nơi sinh";
            // 
            // cmbViTri
            // 
            this.cmbViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViTri.FormattingEnabled = true;
            this.cmbViTri.Items.AddRange(new object[] {
            "Tiền Đạo",
            "Tiền Vệ",
            "Hậu Vệ",
            "Thủ Môn"});
            this.cmbViTri.Location = new System.Drawing.Point(519, 80);
            this.cmbViTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbViTri.Name = "cmbViTri";
            this.cmbViTri.Size = new System.Drawing.Size(219, 28);
            this.cmbViTri.TabIndex = 54;
            // 
            // cmbTenDB
            // 
            this.cmbTenDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenDB.FormattingEnabled = true;
            this.cmbTenDB.Location = new System.Drawing.Point(519, 43);
            this.cmbTenDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenDB.Name = "cmbTenDB";
            this.cmbTenDB.Size = new System.Drawing.Size(217, 28);
            this.cmbTenDB.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(403, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Vị Trí";
            // 
            // txtMaCT
            // 
            this.txtMaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCT.Location = new System.Drawing.Point(141, 44);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(231, 27);
            this.txtMaCT.TabIndex = 47;
            // 
            // txtTenCT
            // 
            this.txtTenCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCT.Location = new System.Drawing.Point(141, 80);
            this.txtTenCT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(229, 27);
            this.txtTenCT.TabIndex = 50;
            // 
            // lblMaTranDau
            // 
            this.lblMaTranDau.AutoSize = true;
            this.lblMaTranDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTranDau.ForeColor = System.Drawing.Color.Black;
            this.lblMaTranDau.Location = new System.Drawing.Point(23, 52);
            this.lblMaTranDau.Name = "lblMaTranDau";
            this.lblMaTranDau.Size = new System.Drawing.Size(90, 19);
            this.lblMaTranDau.TabIndex = 37;
            this.lblMaTranDau.Text = "Mã Cầu Thủ";
            // 
            // lblSoBanThang
            // 
            this.lblSoBanThang.AutoSize = true;
            this.lblSoBanThang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBanThang.ForeColor = System.Drawing.Color.Black;
            this.lblSoBanThang.Location = new System.Drawing.Point(403, 52);
            this.lblSoBanThang.Name = "lblSoBanThang";
            this.lblSoBanThang.Size = new System.Drawing.Size(104, 19);
            this.lblSoBanThang.TabIndex = 38;
            this.lblSoBanThang.Text = "Tên Đội Bóng";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Black;
            this.lblKetQua.Location = new System.Drawing.Point(23, 87);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(93, 19);
            this.lblKetQua.TabIndex = 39;
            this.lblKetQua.Text = "Tên Cầu Thủ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày Sinh";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(744, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 485);
            this.panel2.TabIndex = 61;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnXoa.Location = new System.Drawing.Point(0, 106);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(175, 53);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSua.Location = new System.Drawing.Point(0, 53);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(175, 53);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(175, 53);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQuanLiCauThu
            // 
            this.dgvQuanLiCauThu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuanLiCauThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiCauThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLiCauThu.Location = new System.Drawing.Point(0, 210);
            this.dgvQuanLiCauThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLiCauThu.Name = "dgvQuanLiCauThu";
            this.dgvQuanLiCauThu.RowHeadersWidth = 51;
            this.dgvQuanLiCauThu.RowTemplate.Height = 24;
            this.dgvQuanLiCauThu.Size = new System.Drawing.Size(744, 275);
            this.dgvQuanLiCauThu.TabIndex = 63;
            this.dgvQuanLiCauThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLiCauThu_CellContentClick_1);
            // 
            // frmQLCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 485);
            this.Controls.Add(this.dgvQuanLiCauThu);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLCT";
            this.Text = "Quản Lý Cầu Thủ";
            this.Load += new System.EventHandler(this.QuanLiCauThu_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiCauThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.Label lblMaTranDau;
        private System.Windows.Forms.Label lblSoBanThang;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTenDB;
        private System.Windows.Forms.ComboBox cmbViTri;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.DataGridView dgvQuanLiCauThu;
    }
}