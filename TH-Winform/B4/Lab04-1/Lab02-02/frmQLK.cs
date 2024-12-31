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
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-OJ42HN8;Initial Catalog=QuanLySInhVien;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        //show
        public void HienThi()
        {
            string sql = "Select * From table";
            SqlCommand thuchien = new SqlCommand(sql,ketnoi);
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(docdulieu);
            dgvQLKhoa.DataSource = dt;
        }

        //FORM LOAD
        private void frmFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList(); //lấy các khoa
                //List<Student> listStudent = context.Students.ToList(); //lấy sinh viên
                //FillFalcultyCombobox(listFalcultys);
                BindGrid(listFalcultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm binding gridView từ list skhoa
        private void BindGrid(List<Faculty> listFaculty)
        {
            dgvQLKhoa.Rows.Clear();
            foreach (var item in listFaculty)
            {
                int index = dgvQLKhoa.Rows.Add();
                dgvQLKhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dgvQLKhoa.Rows[index].Cells[1].Value = item.FacultyName;
                dgvQLKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        //Hien thi nguoc thong tin
        private void dgvQLKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvQLKhoa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvQLKhoa.CurrentRow.Selected = true;  //Lay dong hien tai
                txtFacultyID.Text = dgvQLKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFacultyName.Text = dgvQLKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
                //txtTotalProfessor.Text = dgvQLKhoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        //EXIT
        private void btnDong_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        //DELETE
        private void btnXoa_Click(object sender, EventArgs e)
        {

            sql = @"Delete FROM Faculty Where (FacultyID = N'" + txtFacultyID.Text + @"')";
            try
            {
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();
                MessageBox.Show("Xóa Khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                frmFaculty_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //MS chi nhap so
        private void txtFacultyID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //UPDATE
        private void btnSua_Click(object sender, EventArgs e)
        {
            //Check input data
            if (txtFacultyID.Text == "" || txtFacultyName.Text == "")
                throw new Exception("Vui lòng nhập đầy đủ thông tin Khoa!");
            try
            {
                    sql = @"UPDATE Faculty
                            SET     FacultyID = " + txtFacultyID.Text + @", FacultyName = N'" + txtFacultyName.Text + @"', TotalProfessor = " + txtTotalProfessor.Text + @"
                            WHERE   (FacultyID = N'" + txtFacultyID.Text + @"')";
                    ketnoi.Open();
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    frmFaculty_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ketnoi.Close();
            }
        }
        //INSERT
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //Check input data
            if (txtFacultyID.Text == "" || txtFacultyName.Text == "")
                throw new Exception("Vui lòng nhập đầy đủ thông tin Khoa!");
            try
            {
                sql = @"Insert Into Faculty(FacultyID, FacultyName, TotalProfessor)
                        VALUES (" + txtFacultyID.Text + ",N'" + txtFacultyName.Text + "', " + txtTotalProfessor.Text + ")";
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                frmFaculty_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ketnoi.Close();
            }
        }
    }
}
