using Lab02_02.Model2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
        //Khoi tao doi tuong
        Model1 context = new Model1();
        public frmFaculty()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-OJ42HN8;Initial Catalog=QuanLySInhVien;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;

        //SqlDataReader docdulieu;
        //SHOW
        //public void HienThi()
        //{
        //    string sql = "Select * From table";
        //    SqlCommand thuchien = new SqlCommand(sql,ketnoi);
        //    thuchien = new SqlCommand(sql, ketnoi);
        //    docdulieu = thuchien.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(docdulieu);
        //    dgvQLKhoa.DataSource = dt;
        //}

        //FORM LOAD
        private void frmFaculty_Load(object sender, EventArgs e)
        {
            try
            {
                ketnoi = new SqlConnection(chuoiketnoi);
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
                //dgvQLKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
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
                if (thuchien.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK);
                    frmFaculty_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Khoa cần xóa!", "Thông báo", MessageBoxButtons.OK);
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
            try
            {
                if (CheckInput())
                {
                    if (CheckFacultyID(txtFacultyID.Text) == -1)     //-1 la moi
                    {
                        Faculty newFaculty = new Faculty();         //tao doi tuong moi

                        newFaculty.FacultyID = Convert.ToInt32(txtFacultyID.Text);
                        newFaculty.FacultyName = txtFacultyName.Text;
                       // newFaculty.TotalProfessor = Convert.ToInt32(txtTotalProfessor.Text);
                        //Dua moi vao DS
                        context.Faculties.AddOrUpdate(newFaculty);
                        context.SaveChanges();

                        loadDGV();
                        loadForm();
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Lấy phần tử đầu tiên thỏa điều kiện
                        int intFacultyID = Convert.ToInt32(txtFacultyID.Text);
                        Faculty updateFaculty = context.Faculties.FirstOrDefault(p => p.FacultyID == intFacultyID);
                        //kiểm tra đối tượng
                        if (updateFaculty != null)
                        {
                            //gắn các đối tượng update mới
                            updateFaculty.FacultyName = txtFacultyName.Text;
                            //updateFaculty.TotalProfessor = Convert.ToInt32(txtTotalProfessor.Text);
                            //đưa dữ liêu khi thay đổi vào DB
                            context.Faculties.AddOrUpdate(updateFaculty);
                            context.SaveChanges();
                            //Load lai Table DGV
                            loadDGV();
                            loadForm();
                            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
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

        private bool CheckInput()
        {
            //KTTT day du hay chua
            if (txtFacultyID.Text == "" || txtFacultyName.Text == "" || txtTotalProfessor.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;    //Du lieu dung
        }
        //Check da co FacultyID hay chua
        private int CheckFacultyID(string StudentID)
        {
            int length = dgvQLKhoa.Rows.Count;     //Dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvQLKhoa.Rows[i].Cells[0].Value != null)
                    if (dgvQLKhoa.Rows[i].Cells[0].Value.ToString() == StudentID)
                        return i;
            }
            return -1;
        }
        private void loadDGV()
        {
            List<Faculty> newListFaculty = context.Faculties.ToList();   //Lay DS moi tu DB
            BindGrid(newListFaculty);
        }
        //LOAD FORM
        private void loadForm()
        {
            txtFacultyID.Clear();
            txtFacultyName.Clear();
            txtTotalProfessor.Clear();
        }
    }
}
