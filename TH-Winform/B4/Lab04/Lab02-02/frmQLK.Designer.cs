namespace Lab02_02
{
    partial class frmFaculty
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
            this.grbTTK = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.txtTotalProfessor = new System.Windows.Forms.TextBox();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvQLKhoa = new System.Windows.Forms.DataGridView();
            this.dgvFacultyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTTK
            // 
            this.grbTTK.Controls.Add(this.label3);
            this.grbTTK.Controls.Add(this.label2);
            this.grbTTK.Controls.Add(this.label1);
            this.grbTTK.Controls.Add(this.txtFacultyName);
            this.grbTTK.Controls.Add(this.txtTotalProfessor);
            this.grbTTK.Controls.Add(this.txtFacultyID);
            this.grbTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbTTK.Location = new System.Drawing.Point(19, 24);
            this.grbTTK.Name = "grbTTK";
            this.grbTTK.Size = new System.Drawing.Size(361, 202);
            this.grbTTK.TabIndex = 0;
            this.grbTTK.TabStop = false;
            this.grbTTK.Text = "Thông Tin Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số GS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khoa";
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(123, 85);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(216, 30);
            this.txtFacultyName.TabIndex = 0;
            // 
            // txtTotalProfessor
            // 
            this.txtTotalProfessor.Location = new System.Drawing.Point(123, 129);
            this.txtTotalProfessor.Name = "txtTotalProfessor";
            this.txtTotalProfessor.Size = new System.Drawing.Size(167, 30);
            this.txtTotalProfessor.TabIndex = 0;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(123, 38);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(167, 30);
            this.txtFacultyID.TabIndex = 0;
            this.txtFacultyID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFacultyID_KeyPress);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(142, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Thêm / Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(250, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(701, 318);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 26);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvQLKhoa
            // 
            this.dgvQLKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFacultyID,
            this.dgvFacultyName,
            this.dgvTotalProfessor});
            this.dgvQLKhoa.Location = new System.Drawing.Point(386, 33);
            this.dgvQLKhoa.Name = "dgvQLKhoa";
            this.dgvQLKhoa.RowHeadersWidth = 51;
            this.dgvQLKhoa.RowTemplate.Height = 24;
            this.dgvQLKhoa.Size = new System.Drawing.Size(427, 279);
            this.dgvQLKhoa.TabIndex = 2;
            this.dgvQLKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKhoa_CellContentClick);
            // 
            // dgvFacultyID
            // 
            this.dgvFacultyID.HeaderText = "Mã Khoa";
            this.dgvFacultyID.MinimumWidth = 6;
            this.dgvFacultyID.Name = "dgvFacultyID";
            this.dgvFacultyID.Width = 125;
            // 
            // dgvFacultyName
            // 
            this.dgvFacultyName.HeaderText = "Tên Khoa";
            this.dgvFacultyName.MinimumWidth = 6;
            this.dgvFacultyName.Name = "dgvFacultyName";
            this.dgvFacultyName.Width = 125;
            // 
            // dgvTotalProfessor
            // 
            this.dgvTotalProfessor.HeaderText = "Tổng số GS";
            this.dgvTotalProfessor.MinimumWidth = 6;
            this.dgvTotalProfessor.Name = "dgvTotalProfessor";
            this.dgvTotalProfessor.Width = 125;
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 355);
            this.Controls.Add(this.dgvQLKhoa);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grbTTK);
            this.Name = "frmFaculty";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.frmFaculty_Load);
            this.grbTTK.ResumeLayout(false);
            this.grbTTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTK;
        private System.Windows.Forms.TextBox txtFacultyID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.TextBox txtTotalProfessor;
        private System.Windows.Forms.DataGridView dgvQLKhoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFacultyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalProfessor;
    }
}