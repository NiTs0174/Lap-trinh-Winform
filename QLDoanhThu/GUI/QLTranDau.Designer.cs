namespace GUI
{
    partial class frmTranDau
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQuanLiThiDau = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaTD = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMaTranDau = new System.Windows.Forms.Label();
            this.lblNgayThiDau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_NgayTD = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSVD = new System.Windows.Forms.ComboBox();
            this.cmbMaDB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGioTD = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiThiDau)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(723, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 532);
            this.panel2.TabIndex = 29;
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
            this.btnXoa.Size = new System.Drawing.Size(196, 53);
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
            this.btnSua.Size = new System.Drawing.Size(196, 53);
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
            this.btnThem.Size = new System.Drawing.Size(196, 53);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQuanLiThiDau
            // 
            this.dgvQuanLiThiDau.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuanLiThiDau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiThiDau.Location = new System.Drawing.Point(0, 164);
            this.dgvQuanLiThiDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLiThiDau.Name = "dgvQuanLiThiDau";
            this.dgvQuanLiThiDau.RowHeadersWidth = 51;
            this.dgvQuanLiThiDau.RowTemplate.Height = 24;
            this.dgvQuanLiThiDau.Size = new System.Drawing.Size(723, 368);
            this.dgvQuanLiThiDau.TabIndex = 30;
            this.dgvQuanLiThiDau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLiThiDau_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvQuanLiThiDau);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 532);
            this.panel1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaTD);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.lblMaTranDau);
            this.groupBox1.Controls.Add(this.lblNgayThiDau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTime_NgayTD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSVD);
            this.groupBox1.Controls.Add(this.cmbMaDB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtGioTD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 159);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Trận Đấu";
            // 
            // txtMaTD
            // 
            this.txtMaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTD.Location = new System.Drawing.Point(160, 34);
            this.txtMaTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTD.Name = "txtMaTD";
            this.txtMaTD.Size = new System.Drawing.Size(129, 27);
            this.txtMaTD.TabIndex = 19;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(505, 119);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(127, 27);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblMaTranDau
            // 
            this.lblMaTranDau.AutoSize = true;
            this.lblMaTranDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTranDau.ForeColor = System.Drawing.Color.Black;
            this.lblMaTranDau.Location = new System.Drawing.Point(23, 42);
            this.lblMaTranDau.Name = "lblMaTranDau";
            this.lblMaTranDau.Size = new System.Drawing.Size(104, 19);
            this.lblMaTranDau.TabIndex = 12;
            this.lblMaTranDau.Text = "Mã Trận Đấu";
            // 
            // lblNgayThiDau
            // 
            this.lblNgayThiDau.AutoSize = true;
            this.lblNgayThiDau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThiDau.ForeColor = System.Drawing.Color.Black;
            this.lblNgayThiDau.Location = new System.Drawing.Point(23, 85);
            this.lblNgayThiDau.Name = "lblNgayThiDau";
            this.lblNgayThiDau.Size = new System.Drawing.Size(108, 19);
            this.lblNgayThiDau.TabIndex = 14;
            this.lblNgayThiDau.Text = "Ngày Thi Đấu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giờ Thi Đấu";
            // 
            // dateTime_NgayTD
            // 
            this.dateTime_NgayTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_NgayTD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_NgayTD.Location = new System.Drawing.Point(160, 75);
            this.dateTime_NgayTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTime_NgayTD.Name = "dateTime_NgayTD";
            this.dateTime_NgayTD.Size = new System.Drawing.Size(129, 27);
            this.dateTime_NgayTD.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(382, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sân Vận Động";
            // 
            // cmbSVD
            // 
            this.cmbSVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSVD.FormattingEnabled = true;
            this.cmbSVD.Items.AddRange(new object[] {
            "Pleiku",
            "Gò Đậu",
            "Hàng Đẫy",
            "Lạch Tray",
            "Thống Nhất",
            "Thiên Trường",
            "Hòa Xuân",
            "Tam Kỳ"});
            this.cmbSVD.Location = new System.Drawing.Point(505, 72);
            this.cmbSVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSVD.Name = "cmbSVD";
            this.cmbSVD.Size = new System.Drawing.Size(127, 28);
            this.cmbSVD.TabIndex = 22;
            // 
            // cmbMaDB
            // 
            this.cmbMaDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaDB.FormattingEnabled = true;
            this.cmbMaDB.Items.AddRange(new object[] {
            "Hải Phòng",
            "Quảng Bình ",
            "SHB Đà Nẵng",
            "Nam Định",
            "Bình Định",
            "Cà Mau",
            "Nha Trang",
            "Phan Thiết"});
            this.cmbMaDB.Location = new System.Drawing.Point(505, 26);
            this.cmbMaDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaDB.Name = "cmbMaDB";
            this.cmbMaDB.Size = new System.Drawing.Size(127, 28);
            this.cmbMaDB.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(382, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm Kiếm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(379, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đội Khách";
            // 
            // txtGioTD
            // 
            this.txtGioTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioTD.Location = new System.Drawing.Point(160, 115);
            this.txtGioTD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGioTD.Name = "txtGioTD";
            this.txtGioTD.Size = new System.Drawing.Size(129, 27);
            this.txtGioTD.TabIndex = 19;
            // 
            // frmTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 532);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTranDau";
            this.Text = "Quản Lý Trận Đấu";
            this.Load += new System.EventHandler(this.QuanLiTD1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiThiDau)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQuanLiThiDau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DateTimePicker dateTime_NgayTD;
        private System.Windows.Forms.ComboBox cmbMaDB;
        private System.Windows.Forms.TextBox txtGioTD;
        private System.Windows.Forms.TextBox txtMaTD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNgayThiDau;
        private System.Windows.Forms.Label lblMaTranDau;
        private System.Windows.Forms.ComboBox cmbSVD;
    }
}