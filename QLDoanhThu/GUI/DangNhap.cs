using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using DAL;
using DAL.Entities;
using BUS;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //------------------------------------------------------
        private void btnLogin_Click_1(object sender, EventArgs e)
        {            
            using (SqlConnection conn = new SqlConnection("data source=DESKTOP-OJ42HN8;initial catalog=QLDoanhThu;integrated security=True"))
            {
                string tentk = txtTaiKhoan.Text;
                string matKhau = txtMatKhau.Text;
                if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập lại tài khoản!!!"); }
                else if (matKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu !!!"); }
                else
                {
                    string query = "Select * from TAIKHOAN where TaiKhoan = '" + tentk + " ' and MatKhau = '" + matKhau + "'";                    
                    if (modify.TaiKhoans(query).Count != 0)
                    {
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();                               
                        frmHome home = new frmHome();                        
                        //frmHome home = new frmHome(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                        home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên Tài Khoản Hoặc Mật Khẩu Không Chính Xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}