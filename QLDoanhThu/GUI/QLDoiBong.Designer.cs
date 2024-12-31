
namespace GUI
{
    partial class frmQLDB
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
            this.txtTTLH = new System.Windows.Forms.TextBox();
            this.txtMaDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblSoBanThang = new System.Windows.Forms.Label();
            this.lblMaTranDau = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtTenDB = new System.Windows.Forms.TextBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLiDoiBong = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiDoiBong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTTLH
            // 
            this.txtTTLH.Location = new System.Drawing.Point(195, 166);
            this.txtTTLH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTTLH.Name = "txtTTLH";
            this.txtTTLH.Size = new System.Drawing.Size(229, 30);
            this.txtTTLH.TabIndex = 48;
            // 
            // txtMaDB
            // 
            this.txtMaDB.Location = new System.Drawing.Point(195, 37);
            this.txtMaDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDB.Name = "txtMaDB";
            this.txtMaDB.Size = new System.Drawing.Size(231, 30);
            this.txtMaDB.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "TT Liên Hệ";
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
            this.panel2.TabIndex = 41;
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
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKetQua.Location = new System.Drawing.Point(37, 129);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(64, 20);
            this.lblKetQua.TabIndex = 39;
            this.lblKetQua.Text = "Địa Chỉ";
            // 
            // lblSoBanThang
            // 
            this.lblSoBanThang.AutoSize = true;
            this.lblSoBanThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBanThang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoBanThang.Location = new System.Drawing.Point(37, 86);
            this.lblSoBanThang.Name = "lblSoBanThang";
            this.lblSoBanThang.Size = new System.Drawing.Size(111, 20);
            this.lblSoBanThang.TabIndex = 38;
            this.lblSoBanThang.Text = "Tên Đội Bóng";
            // 
            // lblMaTranDau
            // 
            this.lblMaTranDau.AutoSize = true;
            this.lblMaTranDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTranDau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaTranDau.Location = new System.Drawing.Point(37, 44);
            this.lblMaTranDau.Name = "lblMaTranDau";
            this.lblMaTranDau.Size = new System.Drawing.Size(106, 20);
            this.lblMaTranDau.TabIndex = 37;
            this.lblMaTranDau.Text = "Mã Đội Bóng";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(195, 122);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(229, 30);
            this.txtDC.TabIndex = 50;
            // 
            // txtTenDB
            // 
            this.txtTenDB.Location = new System.Drawing.Point(195, 79);
            this.txtTenDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDB.Name = "txtTenDB";
            this.txtTenDB.Size = new System.Drawing.Size(229, 30);
            this.txtTenDB.TabIndex = 51;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.groupBox2);
            this.grbThongTin.Controls.Add(this.txtMaDB);
            this.grbThongTin.Controls.Add(this.txtTTLH);
            this.grbThongTin.Controls.Add(this.txtDC);
            this.grbThongTin.Controls.Add(this.txtTenDB);
            this.grbThongTin.Controls.Add(this.lblMaTranDau);
            this.grbThongTin.Controls.Add(this.lblSoBanThang);
            this.grbThongTin.Controls.Add(this.lblKetQua);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.ForeColor = System.Drawing.Color.Red;
            this.grbThongTin.Location = new System.Drawing.Point(0, 0);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTin.Size = new System.Drawing.Size(744, 210);
            this.grbThongTin.TabIndex = 52;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(462, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(274, 115);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(7, 69);
            this.txtTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(260, 30);
            this.txtTK.TabIndex = 52;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Đội Bóng";
            // 
            // dgvQuanLiDoiBong
            // 
            this.dgvQuanLiDoiBong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQuanLiDoiBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLiDoiBong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLiDoiBong.Location = new System.Drawing.Point(0, 210);
            this.dgvQuanLiDoiBong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLiDoiBong.Name = "dgvQuanLiDoiBong";
            this.dgvQuanLiDoiBong.RowHeadersWidth = 51;
            this.dgvQuanLiDoiBong.RowTemplate.Height = 24;
            this.dgvQuanLiDoiBong.Size = new System.Drawing.Size(744, 275);
            this.dgvQuanLiDoiBong.TabIndex = 53;
            this.dgvQuanLiDoiBong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLiDoiBong_CellContentClick);
            // 
            // frmQLDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 485);
            this.Controls.Add(this.dgvQuanLiDoiBong);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLDB";
            this.Text = "Quản Lý Đội Bóng";
            this.Load += new System.EventHandler(this.QuanLiDoiBong_Load);
            this.panel2.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLiDoiBong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTTLH;
        private System.Windows.Forms.TextBox txtMaDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblSoBanThang;
        private System.Windows.Forms.Label lblMaTranDau;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtTenDB;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanLiDoiBong;
    }
}