using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab02_02.Models;

namespace Lab02_02
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=DESKTOP-OJ42HN8;Initial Catalog=QuanLySInhVien;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        
        //1.1 FORM LOAD
        private void frmStudentManagement_Load_1(object sender, EventArgs e)
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList(); //lấy các khoa
                List<Student> listStudent = context.Students.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Hàm binding list có tên hiện thị là tên khoa, giá trị là Mã khoa
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbFaculty.DataSource = listFalcultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        //Hàm binding gridView từ list sinh viên
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AvgScore;
            }
        }

        //1.4 Hien Thi Du Lieu Nguoc
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtFullName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbFaculty.SelectedItem = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtAvgScore.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //RESET TEXT
        private void Reset()
        {
            txtStudentID.Text = "";
            txtFullName.Text = "";
            cmbFaculty.Text = "Công Nghệ Thông Tin";
            txtAvgScore.Text = "";
        }

        //MSSV chi nhap so
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Check input data
        private bool CheckInput()
        { 
            //KTTT
            if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAvgScore.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!");
                return false;
            }
            // Kiểm tra mã số sinh viên có 10 kí tự hay không
            if (txtStudentID.Text.Length != 10)
            {
                MessageBox.Show("Mã số sinh viên phải có 10 kí tự!");
                return false;
            }
            return true;
        }

        //1.2 INSERT
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                sql = @"Insert Into Student(StudentID, FullName, AvgScore, FacultyID)
                        VALUES (N'" + txtStudentID.Text + @"',N'" + txtFullName.Text + @"', " + txtAvgScore.Text + @"," + 1 + @")";
                try
                {
                    ketnoi.Open();
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    frmStudentManagement_Load_1(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ketnoi.Close();
                }
            }
            Reset();
        }

        //1.2 UPDATE
        private void btnSua_Click_1(object sender, EventArgs e)
        {
                sql = @"UPDATE Student 
                        SET     StudentID = N'" + txtStudentID.Text + @"', FullName = N'" + txtFullName.Text + @"', AvgScore = " + txtAvgScore.Text + @"
                        WHERE   (StudentID = N'" + txtStudentID.Text + @"')";
                try
                {
                    ketnoi.Open();
                    thuchien = new SqlCommand(sql, ketnoi);
                    if (thuchien.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                        frmStudentManagement_Load_1(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy MSSV cần sửa!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ketnoi.Close();
                }
            Reset();
        }

        //1.3 DELETE
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
                sql = @"Delete FROM Student Where (StudentID = N'" + txtStudentID.Text + @"')";
                try
                {
                    ketnoi.Open();
                    thuchien = new SqlCommand(sql, ketnoi);
                    if (thuchien.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                        frmStudentManagement_Load_1(sender, e);
                    }
                    else 
                    {
                        MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    ketnoi.Close();
                }
            Reset();
        }

        //EXIT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //FROM Quan Ly Khoa
        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmFaculty frmFaculty = new frmFaculty();
            frmFaculty.Show();
        }

        //FORM SEARCH
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frmTimKiem = new frmTimKiem();
            frmTimKiem.Show();
        }

    }
}
