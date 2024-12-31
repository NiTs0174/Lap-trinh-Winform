using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using static System.Net.Mime.MediaTypeNames;
using DAL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        //----------------------------------------
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null) { currentFormChild.Close(); }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childform);
            panel_Body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //-------------------------QLTD--------------------------------
        private void btnQuanLiThiDau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTranDau());
        }
        //-------------------------QLDB--------------------------------
        private void btnQLDB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLDB());
        }
        //----------------------------QLCT-----------------------------
        private void btnQLCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLCT());
        }
        //--------------------------QLDT------------------------------
        private void btnQLDT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLVe());
        }
        //--------------------------QLDT------------------------------
        private void btnNTT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLNTT());
        }
        //--------------------------------Thoát--------------------------------
        private void btnThoát_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
            }
        }
        //--------------------------------ĐăngXuất--------------------------------------
        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.ShowDialog();
        }
        //--------------------------------QLTK--------------------------------
        private void btnTK_Click(object sender, EventArgs e)
        {
                OpenChildForm(new frmQLTaiKhoan());
        }
        //------------------------------------------------
        //string taiKhoan = "", matKhau = "", loaiTK = "";
        //public frmHome(string taiKhoan, string matKhau, string loaiTK)
        //{
        //    this.taiKhoan = taiKhoan;
        //    this.matKhau = matKhau;
        //    this.loaiTK = loaiTK;
        //}
        //private void frmHome_Load(object sender, EventArgs e)
        //{
        //    if (loaiTK != "admin")
        //    {
        //        btnTK.Visible = false;
        //    }
        //}
    }
}
