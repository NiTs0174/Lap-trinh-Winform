namespace Lab02_02
{
    partial class dgvStudentID
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
            this.components = new System.ComponentModel.Container();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAvgScore = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblChuyenNganh = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTSVNam = new System.Windows.Forms.Label();
            this.lblTSVNu = new System.Windows.Forms.Label();
            this.txtTSVNam = new System.Windows.Forms.TextBox();
            this.txtTSVNu = new System.Windows.Forms.TextBox();
            this.lblQLTTSV = new System.Windows.Forms.Label();
            this.lblTTSV = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvMSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optNam = new System.Windows.Forms.RadioButton();
            this.optNu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(128, 119);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(160, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // txtAvgScore
            // 
            this.txtAvgScore.Location = new System.Drawing.Point(128, 228);
            this.txtAvgScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvgScore.Name = "txtAvgScore";
            this.txtAvgScore.Size = new System.Drawing.Size(88, 20);
            this.txtAvgScore.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(128, 157);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(160, 20);
            this.txtFullName.TabIndex = 5;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(38, 157);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 7;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // lblChuyenNganh
            // 
            this.lblChuyenNganh.AutoSize = true;
            this.lblChuyenNganh.Location = new System.Drawing.Point(38, 272);
            this.lblChuyenNganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChuyenNganh.Name = "lblChuyenNganh";
            this.lblChuyenNganh.Size = new System.Drawing.Size(78, 13);
            this.lblChuyenNganh.TabIndex = 8;
            this.lblChuyenNganh.Text = "Chuyên Ngành";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(38, 233);
            this.lblDTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(48, 13);
            this.lblDTB.TabIndex = 9;
            this.lblDTB.Text = "Điểm TB";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(38, 198);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 10;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(38, 121);
            this.lblMSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(70, 13);
            this.lblMSV.TabIndex = 11;
            this.lblMSV.Text = "Mã Sinh Viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(124, 272);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(164, 21);
            this.cmbFaculty.TabIndex = 14;
            this.cmbFaculty.Text = "QTKD";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(128, 318);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 19);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Thêm/ Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(215, 318);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTSVNam
            // 
            this.lblTSVNam.AutoSize = true;
            this.lblTSVNam.Location = new System.Drawing.Point(416, 320);
            this.lblTSVNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTSVNam.Name = "lblTSVNam";
            this.lblTSVNam.Size = new System.Drawing.Size(105, 13);
            this.lblTSVNam.TabIndex = 18;
            this.lblTSVNam.Text = "Tổng Sinh Viên Nam";
            // 
            // lblTSVNu
            // 
            this.lblTSVNu.AutoSize = true;
            this.lblTSVNu.Location = new System.Drawing.Point(598, 320);
            this.lblTSVNu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTSVNu.Name = "lblTSVNu";
            this.lblTSVNu.Size = new System.Drawing.Size(21, 13);
            this.lblTSVNu.TabIndex = 19;
            this.lblTSVNu.Text = "Nữ";
            // 
            // txtTSVNam
            // 
            this.txtTSVNam.Enabled = false;
            this.txtTSVNam.Location = new System.Drawing.Point(518, 318);
            this.txtTSVNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtTSVNam.Name = "txtTSVNam";
            this.txtTSVNam.Size = new System.Drawing.Size(58, 20);
            this.txtTSVNam.TabIndex = 20;
            this.txtTSVNam.Tag = "";
            // 
            // txtTSVNu
            // 
            this.txtTSVNu.Enabled = false;
            this.txtTSVNu.Location = new System.Drawing.Point(620, 318);
            this.txtTSVNu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTSVNu.Name = "txtTSVNu";
            this.txtTSVNu.Size = new System.Drawing.Size(58, 20);
            this.txtTSVNu.TabIndex = 22;
            // 
            // lblQLTTSV
            // 
            this.lblQLTTSV.AutoSize = true;
            this.lblQLTTSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.lblQLTTSV.Location = new System.Drawing.Point(176, 21);
            this.lblQLTTSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQLTTSV.Name = "lblQLTTSV";
            this.lblQLTTSV.Size = new System.Drawing.Size(272, 25);
            this.lblQLTTSV.TabIndex = 23;
            this.lblQLTTSV.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // lblTTSV
            // 
            this.lblTTSV.AutoSize = true;
            this.lblTTSV.Location = new System.Drawing.Point(14, 80);
            this.lblTTSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTTSV.Name = "lblTTSV";
            this.lblTTSV.Size = new System.Drawing.Size(104, 13);
            this.lblTTSV.TabIndex = 24;
            this.lblTTSV.Text = "Thông Tin Sinh Viên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMSV,
            this.dgvHoTen,
            this.dgvGioiTinh,
            this.dgvDTB,
            this.dgvKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(309, 66);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(350, 219);
            this.dgvStudent.TabIndex = 25;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick_1);
            // 
            // dgvMSV
            // 
            this.dgvMSV.HeaderText = "Mã SV";
            this.dgvMSV.MinimumWidth = 6;
            this.dgvMSV.Name = "dgvMSV";
            this.dgvMSV.Width = 75;
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.HeaderText = "Họ Tên";
            this.dgvHoTen.MinimumWidth = 6;
            this.dgvHoTen.Name = "dgvHoTen";
            this.dgvHoTen.Width = 125;
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Giới Tính";
            this.dgvGioiTinh.MinimumWidth = 6;
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            this.dgvGioiTinh.Width = 50;
            // 
            // dgvDTB
            // 
            this.dgvDTB.HeaderText = "Điểm TB";
            this.dgvDTB.MinimumWidth = 6;
            this.dgvDTB.Name = "dgvDTB";
            this.dgvDTB.Width = 50;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.HeaderText = "Khoa";
            this.dgvKhoa.MinimumWidth = 6;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // optNam
            // 
            this.optNam.AutoSize = true;
            this.optNam.Location = new System.Drawing.Point(128, 194);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(47, 17);
            this.optNam.TabIndex = 27;
            this.optNam.Text = "Nam";
            this.optNam.UseVisualStyleBackColor = true;
            // 
            // optNu
            // 
            this.optNu.AutoSize = true;
            this.optNu.Checked = true;
            this.optNu.Location = new System.Drawing.Point(215, 194);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(39, 17);
            this.optNu.TabIndex = 27;
            this.optNu.TabStop = true;
            this.optNu.Text = "Nữ";
            this.optNu.UseVisualStyleBackColor = true;
            // 
            // dgvStudentID
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.optNu);
            this.Controls.Add(this.optNam);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblTTSV);
            this.Controls.Add(this.lblQLTTSV);
            this.Controls.Add(this.txtTSVNu);
            this.Controls.Add(this.txtTSVNam);
            this.Controls.Add(this.lblTSVNu);
            this.Controls.Add(this.lblTSVNam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.lblMSV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.lblChuyenNganh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtAvgScore);
            this.Controls.Add(this.txtStudentID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dgvStudentID";
            this.Text = "Quản Lý Thông TIn Sinh Viên";
            this.Load += new System.EventHandler(this.dgvStudentID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtAvgScore;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblChuyenNganh;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTSVNam;
        private System.Windows.Forms.Label lblTSVNu;
        private System.Windows.Forms.TextBox txtTSVNam;
        private System.Windows.Forms.TextBox txtTSVNu;
        private System.Windows.Forms.Label lblQLTTSV;
        private System.Windows.Forms.Label lblTTSV;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.RadioButton optNu;
    }
}

