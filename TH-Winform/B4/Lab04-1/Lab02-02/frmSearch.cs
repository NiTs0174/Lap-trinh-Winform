using Lab02_02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-OJ42HN8;Initial Catalog=QuanLySInhVien;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        //LOAD FORM
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                StudentContextDB context = new StudentContextDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //EXIT
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //RESET
        private void Reset()
        {
            txtStudentID = null;
            txtFullName.Text = null;
            cmbFaculty.Text = null;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //dgvTimKiem.Rows.Clear();
            Reset();
        }

        //SEARCH
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy điều kiện tìm kiếm từ TextBox
            //string searchText = txtStudentID.Text;

            // Kiểm tra xem người dùng đã nhập điều kiện tìm kiếm hay chưa
            if (txtFullName.Text != null || txtStudentID != null || cmbFaculty != null)
            {
                try
                {
                    ketnoi.Open();
                    sql = "SELECT a.StudentID, FullName, FacultyName, AvgScore FROM Student a, Faculty b WHERE a.FacultyID = b.FacultyID AND (StudentID IS NULL OR StudentID like '" + txtStudentID.Text + "') AND (FullName IS NULL OR FullName like '%" + txtFullName.Text + "%') AND (FacultyName IS NULL OR FacultyName like N'" + cmbFaculty.Text + "')";
                        
                    SqlDataAdapter da = new SqlDataAdapter(sql, ketnoi);

                    //thuchien = new SqlCommand(sql, ketnoi);
                    //docdulieu = thuchien.ExecuteReader();
                    DataTable dt = new DataTable();
                    //dt.Load(docdulieu);
                    da.Fill(dt);
                    dgvTimKiem.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                }
                finally
                {
                    ketnoi.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điều kiện tìm kiếm.");
            }
        }

        //SUM
        private void sum()
        {
            int Count = 0;
            for (int i = 0; i < dgvTimKiem.Rows.Count; i++)
            {
                Count++;
            }
            txtKQTK.Text = Count.ToString();
        }
    }
}
