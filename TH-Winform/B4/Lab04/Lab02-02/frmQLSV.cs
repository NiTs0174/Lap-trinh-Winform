using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab02_02.Model2;

namespace Lab02_02
{
    public partial class frmStudentManagement : Form
    {
        //Khoi tao doi tuong SV
        Model1 context = new Model1();
        public frmStudentManagement()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-OJ42HN8;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        //SqlDataReader docdulieu;

        //1.1 Event FORMLOAD
        private void frmStudentManagement_Load_1(object sender, EventArgs e)
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
                //Goi CSDL - DS SV, Khoa
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
        private void BindGrid(List<Student> listStudent)    //FillDataStudent
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;
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

        //MSSV chi nhap so - Event
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
            //KTTT day du hay chua
            if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAvgScore.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!");
                return false;
            }
            // Kiểm tra mã số sinh viên có 10 kí tự hay không
            else if (txtStudentID.Text.Length != 10)
            {
                MessageBox.Show("Mã số sinh viên phải có 10 kí tự!");
                return false;
            }
            else
            {
                float kq = 0;
                bool KetQua = float.TryParse(txtAvgScore.Text, out kq);
                if (!KetQua)
                {
                    MessageBox.Show("Điểm Sinh viên chưa đúng!");
                    return false;
                }
            }
            return true;    //Du lieu dung
        }
        //Check da co StudentID hay chua
        private int CheckStudentID(string StudentID)
        {
            int length = dgvStudent.Rows.Count;     //Dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null)
                    if (dgvStudent.Rows[i].Cells[0].Value.ToString() == StudentID)
                        return i;
            }
            return -1;
        }
        private void loadDGV()
        {
            List<Student> newListStudet = context.Students.ToList();   //Lay DS moi tu DB
            BindGrid(newListStudet);
        }
        //LOAD FORM
        private void loadForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAvgScore.Clear();
        }

        //1.2 INSERT
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    if (CheckStudentID(txtStudentID.Text) == -1)     //-1 la SV moi
                    {
                        Student newStudent = new Student();         //tao doi tuong SV moi

                        newStudent.StudentID = txtStudentID.Text;
                        newStudent.FullName = txtFullName.Text;
                        newStudent.AverageScore = Convert.ToDouble(txtAvgScore.Text);
                        newStudent.FacultyID = Convert.ToInt32(cmbFaculty.SelectedValue.ToString());
                        //Dua SV moi vao DS
                        context.Students.AddOrUpdate(newStudent);
                        context.SaveChanges();

                        loadDGV();
                        loadForm();
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Mã số Sinh viên đã tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //1.2 UPDATE
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    //Lấy phần tử đầu tiên thỏa điều kiện
                    Student updateStudent = context.Students.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
                    //kiểm tra đối tượng
                    if (updateStudent != null)
                    {
                        //gắn các đối tượng update mới
                        updateStudent.FullName = txtFullName.Text;
                        updateStudent.AverageScore = Convert.ToDouble(txtAvgScore.Text);
                        updateStudent.FacultyID = Convert.ToInt32(cmbFaculty.SelectedValue.ToString());
                        //đưa dữ liêu khi thay đổi vào DB
                        context.Students.AddOrUpdate(updateStudent);
                        context.SaveChanges();
                        //Load lai Table DGV
                        loadDGV();
                        loadForm();
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy MSSV cần sửa!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                loadForm();
            //try
            //{
            //    Student deleteStudent = context.Students.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
            //    if (deleteStudent != null)
            //    {
            //        DialogResult result = MessageBox.Show("Bạn có muốn xóa Sinh viên!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //        if (result == DialogResult.Yes)
            //        {
            //            //xóa dữ liêu
            //            context.Students.Remove(deleteStudent);
            //            context.SaveChanges();
            //            //Load lai Table DGV
            //            loadDGV();
            //            loadForm();
            //            MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //EXIT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
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
