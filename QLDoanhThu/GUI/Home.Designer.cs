namespace GUI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNTT = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnDX = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.btnQLDT = new System.Windows.Forms.Button();
            this.btnQLCT = new System.Windows.Forms.Button();
            this.btnQLDB = new System.Windows.Forms.Button();
            this.btnQuanLiThiDau = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.panel_Body.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Body
            // 
            this.panel_Body.Controls.Add(this.panel1);
            this.panel_Body.Controls.Add(this.pictureBox1);
            this.panel_Body.Controls.Add(this.menuStrip1);
            this.panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Body.Location = new System.Drawing.Point(0, 0);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1182, 653);
            this.panel_Body.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNTT);
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Controls.Add(this.btnDX);
            this.panel1.Controls.Add(this.btnThoát);
            this.panel1.Controls.Add(this.btnQLDT);
            this.panel1.Controls.Add(this.btnQLCT);
            this.panel1.Controls.Add(this.btnQLDB);
            this.panel1.Controls.Add(this.btnQuanLiThiDau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 622);
            this.panel1.TabIndex = 1;
            // 
            // btnNTT
            // 
            this.btnNTT.BackColor = System.Drawing.Color.White;
            this.btnNTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNTT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNTT.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnNTT.Location = new System.Drawing.Point(0, 236);
            this.btnNTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNTT.Name = "btnNTT";
            this.btnNTT.Size = new System.Drawing.Size(227, 59);
            this.btnNTT.TabIndex = 9;
            this.btnNTT.Text = "Nhà Tài Trợ";
            this.btnNTT.UseVisualStyleBackColor = false;
            this.btnNTT.Click += new System.EventHandler(this.btnNTT_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.White;
            this.btnTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTK.Location = new System.Drawing.Point(0, 445);
            this.btnTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(227, 59);
            this.btnTK.TabIndex = 8;
            this.btnTK.Text = "Tài Khoản";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnDX
            // 
            this.btnDX.BackColor = System.Drawing.Color.White;
            this.btnDX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDX.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnDX.Location = new System.Drawing.Point(0, 504);
            this.btnDX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(227, 59);
            this.btnDX.TabIndex = 7;
            this.btnDX.Text = "Đăng Xuất";
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.BackColor = System.Drawing.Color.White;
            this.btnThoát.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoát.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoát.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoát.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThoát.Location = new System.Drawing.Point(0, 563);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(227, 59);
            this.btnThoát.TabIndex = 6;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = false;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // btnQLDT
            // 
            this.btnQLDT.BackColor = System.Drawing.Color.White;
            this.btnQLDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDT.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQLDT.Location = new System.Drawing.Point(0, 177);
            this.btnQLDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Size = new System.Drawing.Size(227, 59);
            this.btnQLDT.TabIndex = 5;
            this.btnQLDT.Text = "Doanh Thu Vé";
            this.btnQLDT.UseVisualStyleBackColor = false;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click_1);
            // 
            // btnQLCT
            // 
            this.btnQLCT.BackColor = System.Drawing.Color.White;
            this.btnQLCT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLCT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCT.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQLCT.Location = new System.Drawing.Point(0, 118);
            this.btnQLCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLCT.Name = "btnQLCT";
            this.btnQLCT.Size = new System.Drawing.Size(227, 59);
            this.btnQLCT.TabIndex = 4;
            this.btnQLCT.Text = "Cầu Thủ";
            this.btnQLCT.UseVisualStyleBackColor = false;
            this.btnQLCT.Click += new System.EventHandler(this.btnQLCT_Click);
            // 
            // btnQLDB
            // 
            this.btnQLDB.BackColor = System.Drawing.Color.White;
            this.btnQLDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDB.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQLDB.Location = new System.Drawing.Point(0, 59);
            this.btnQLDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLDB.Name = "btnQLDB";
            this.btnQLDB.Size = new System.Drawing.Size(227, 59);
            this.btnQLDB.TabIndex = 3;
            this.btnQLDB.Text = "Đội Bóng";
            this.btnQLDB.UseVisualStyleBackColor = false;
            this.btnQLDB.Click += new System.EventHandler(this.btnQLDB_Click);
            // 
            // btnQuanLiThiDau
            // 
            this.btnQuanLiThiDau.BackColor = System.Drawing.Color.White;
            this.btnQuanLiThiDau.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLiThiDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLiThiDau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLiThiDau.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnQuanLiThiDau.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLiThiDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLiThiDau.Name = "btnQuanLiThiDau";
            this.btnQuanLiThiDau.Size = new System.Drawing.Size(227, 59);
            this.btnQuanLiThiDau.TabIndex = 2;
            this.btnQuanLiThiDau.Text = "Trận Đấu";
            this.btnQuanLiThiDau.UseVisualStyleBackColor = false;
            this.btnQuanLiThiDau.Click += new System.EventHandler(this.btnQuanLiThiDau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Enabled = false;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.hOMEToolStripMenuItem.Text = "HOME";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tùyChọnToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.tùyChọnToolStripMenuItem.Enabled = false;
            this.tùyChọnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel_Body);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "TRANG CHỦ";
            this.panel_Body.ResumeLayout(false);
            this.panel_Body.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLiThiDau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQLDB;
        private System.Windows.Forms.Button btnQLCT;
        private System.Windows.Forms.Button btnQLDT;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Button btnNTT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.ToolStripTextBox tùyChọnToolStripMenuItem;
    }
}