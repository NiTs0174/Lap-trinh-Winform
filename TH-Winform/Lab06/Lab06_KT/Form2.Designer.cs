
namespace Lab06_KT
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvTruyVet = new System.Windows.Forms.DataGridView();
            this.dgvMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTingTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruyVet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truy vết theo nguồn lây nhiễm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bệnh nhân";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dgvTruyVet
            // 
            this.dgvTruyVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruyVet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaBN,
            this.dgvTenBN,
            this.dgvTingTrang,
            this.dgvF});
            this.dgvTruyVet.Location = new System.Drawing.Point(12, 144);
            this.dgvTruyVet.Name = "dgvTruyVet";
            this.dgvTruyVet.Size = new System.Drawing.Size(443, 294);
            this.dgvTruyVet.TabIndex = 1;
            // 
            // dgvMaBN
            // 
            this.dgvMaBN.HeaderText = "Mã BN";
            this.dgvMaBN.Name = "dgvMaBN";
            // 
            // dgvTenBN
            // 
            this.dgvTenBN.HeaderText = "Tên BN";
            this.dgvTenBN.Name = "dgvTenBN";
            // 
            // dgvTingTrang
            // 
            this.dgvTingTrang.HeaderText = "Tình Trạng";
            this.dgvTingTrang.Name = "dgvTingTrang";
            // 
            // dgvF
            // 
            this.dgvF.HeaderText = "F";
            this.dgvF.Name = "dgvF";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.dgvTruyVet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruyVet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvTruyVet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTingTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvF;
    }
}