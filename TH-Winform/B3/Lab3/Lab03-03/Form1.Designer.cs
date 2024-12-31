namespace Lab03_03
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuQLSV = new System.Windows.Forms.MenuStrip();
            this.menuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripQLSV = new System.Windows.Forms.ToolStrip();
            this.btnThemImg = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuQLSV.SuspendLayout();
            this.toolStripQLSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // menuQLSV
            // 
            this.menuQLSV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuQLSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucNang});
            this.menuQLSV.Location = new System.Drawing.Point(0, 0);
            this.menuQLSV.Name = "menuQLSV";
            this.menuQLSV.Size = new System.Drawing.Size(800, 28);
            this.menuQLSV.TabIndex = 0;
            this.menuQLSV.Text = "menuStrip1";
            // 
            // menuChucNang
            // 
            this.menuChucNang.Name = "menuChucNang";
            this.menuChucNang.Size = new System.Drawing.Size(93, 24);
            this.menuChucNang.Text = "Chức năng";
            // 
            // toolStripQLSV
            // 
            this.toolStripQLSV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripQLSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemImg,
            this.btnThem,
            this.txtTimKiem});
            this.toolStripQLSV.Location = new System.Drawing.Point(0, 28);
            this.toolStripQLSV.Name = "toolStripQLSV";
            this.toolStripQLSV.Size = new System.Drawing.Size(800, 35);
            this.toolStripQLSV.TabIndex = 1;
            this.toolStripQLSV.Text = "toolStrip1";
            // 
            // btnThemImg
            // 
            this.btnThemImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThemImg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThemImg.Image = ((System.Drawing.Image)(resources.GetObject("btnThemImg.Image")));
            this.btnThemImg.ImageTransparentColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnThemImg.Name = "btnThemImg";
            this.btnThemImg.Size = new System.Drawing.Size(29, 32);
            this.btnThemImg.Text = "toolStripButton1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 1, 100, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 32);
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 35);
            this.txtTimKiem.Text = "Tìm kiếm theo tên";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvMSSV,
            this.dgvTenSV,
            this.dgvKhoa,
            this.dgvDTB});
            this.dgvStudent.Location = new System.Drawing.Point(0, 66);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(800, 387);
            this.dgvStudent.TabIndex = 2;
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "Số TT";
            this.dgvSTT.MinimumWidth = 6;
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.Width = 125;
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "Mã Số SV";
            this.dgvMSSV.MinimumWidth = 6;
            this.dgvMSSV.Name = "dgvMSSV";
            this.dgvMSSV.Width = 150;
            // 
            // dgvTenSV
            // 
            this.dgvTenSV.HeaderText = "Tên Sinh Viên";
            this.dgvTenSV.MinimumWidth = 6;
            this.dgvTenSV.Name = "dgvTenSV";
            this.dgvTenSV.Width = 175;
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.HeaderText = "Khoa";
            this.dgvKhoa.MinimumWidth = 6;
            this.dgvKhoa.Name = "dgvKhoa";
            this.dgvKhoa.Width = 175;
            // 
            // dgvDTB
            // 
            this.dgvDTB.HeaderText = "Điểm TB";
            this.dgvDTB.MinimumWidth = 6;
            this.dgvDTB.Name = "dgvDTB";
            this.dgvDTB.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.toolStripQLSV);
            this.Controls.Add(this.menuQLSV);
            this.MainMenuStrip = this.menuQLSV;
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.menuQLSV.ResumeLayout(false);
            this.menuQLSV.PerformLayout();
            this.toolStripQLSV.ResumeLayout(false);
            this.toolStripQLSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuQLSV;
        private System.Windows.Forms.ToolStripMenuItem menuChucNang;
        private System.Windows.Forms.ToolStrip toolStripQLSV;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTB;
        private System.Windows.Forms.ToolStripButton btnThemImg;
    }
}

