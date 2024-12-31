using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.BUS;
using Lab05.DAL.Entities;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;

namespace Lab05.GUI
{
    public partial class frmStudent : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        Model1 context = new Model1();
        public frmStudent()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------
        //FORM LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //------------------------------------------------------------------------
        //Hàm binding list dữ liệu khoa vào combobox có tên hiện thị là tên khoa,
        //giá trị là Mã khoa
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        //------------------------------------------------------------------------
        //Hàm binding gridView từ list sinh viên
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvStudent.Rows[index].Cells[4].Value = item.Major.Name + "";
                ShowAvatar(item.Avatar);
            }
        }
        //------------------------------------------------------------------------
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                picAvatar.Image = null;
            }
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                picAvatar.Image = Image.FromFile(imagePath);
                picAvatar.Refresh();
            }
        }
        //------------------------------------------------------------------------
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        //------------------------------------------------------------------------
        private void chkDKChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkUnregisterMajor.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }
        //------------------------------------------------------------------------
        //TRA NGUOC DU LIEU
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtFullName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbFaculty.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtAverageScore.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------
        //ID INPUT ONLY NUMBER
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //CHECK DATA
        private bool CheckData()
        {
            //KTTT day du hay chua
            if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
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
                bool KetQua = float.TryParse(txtAverageScore.Text, out kq);
                if (!KetQua)
                {
                    MessageBox.Show("Điểm Sinh viên chưa đúng!");
                    return false;
                }
            }
            return true;    //Du lieu dung
        }
        //Check ID
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
        //------------------------------------------------------------------------
        //LOAD DATA
        private void LoadData()
        {
            List<Student> newListStudet = studentService.GetAll();   //Lay DS moi tu DB
            BindGrid(newListStudet);
        }
        //REFRESH
        private void refresh()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
        }
        //------------------------------------------------------------------------
        //ADD AVATAR
        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            String imageLocation = " ";
            try
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = " Chọn hình ảnh sinh viên & ";
                fileOpen.Filter = " Hình ảnh(*.jpg; *.jpeg; *.png)| *.jpg; *.jpeg; *.png | Allfiles(*.*) | *.* ";
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = fileOpen.FileName;
                    picAvatar.Image = Image.FromFile(imageLocation);
                    pathImage = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Lỗi không thể upload ảnh! ", " Lỗi & ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------
        private string pathImage;
        //------------------------------------------------------------------------
        //ADD OR UPDATE
        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            if (CheckData())
            {
                if (CheckStudentID(txtStudentID.Text) == 1)
                {
                    //string id = txtStudentID.Text.Trim();
                    Student stuUpdate = studentService.GetAll().FirstOrDefault(p => p.StudentID == txtStudentID.Text);
                    if (stuUpdate != null)
                    {
                        stuUpdate.FullName = txtFullName.Text.Trim();
                        stuUpdate.AverageScore = double.Parse(txtAverageScore.Text);
                        stuUpdate.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                        if (!string.IsNullOrEmpty(pathImage) && File.Exists(pathImage))
                        {
                            string imageName = txtStudentID.Text.Trim().ToString() + "."
                           + Path.GetExtension(pathImage).TrimStart('.'); string parentDirectory =
                            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName; string imagePath = Path.Combine(parentDirectory, "Images");
                            if (!Directory.Exists(imagePath))
                           {
                                Directory.CreateDirectory(imagePath);
                            }
                           string imageDestinationPath = Path.Combine(imagePath, imageName);
                            File.Copy(pathImage, imageDestinationPath, true);
                            stuUpdate.Avatar = imageName;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi upload hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                        }
                            studentService.InsertUpdate(stuUpdate);
                            LoadData(); refresh();
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); btnDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên trong hệ thống!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(pathImage) && File.Exists(pathImage))
                    {
                        string imageName = txtStudentID.Text.Trim().ToString() + "." +
                        Path.GetExtension(pathImage).TrimStart('.');
                        // Kiểm tra xem thư mục "Images" có tồn tại không, nếu không, tạo mới
                        string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName; string imagePath = Path.Combine(parentDirectory, "Images");
                       if (!Directory.Exists(imagePath))
                        {
                            Directory.CreateDirectory(imagePath);
                        }
                        string imageDestinationPath = Path.Combine(imagePath, imageName);
                        // Copy image gốc sang thư mục Images
                        File.Copy(pathImage, imageDestinationPath, true);
                        Student stu = new Student();
                        {
                            stu.StudentID = txtStudentID.Text;
                            stu.FullName = txtFullName.Text;
                            stu.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                            stu.AverageScore = float.Parse(txtAverageScore.Text);
                            //stu.Avatar = imageName;
                        };
                        studentService.InsertUpdate(stu);
                        LoadData(); 
                        refresh(); 
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); btnDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi upload hình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        //------------------------------------------------------------------------
        //DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAddOrUpdate.Enabled = false;
            if (CheckData())
            {
                Student stuDelete = context.Students.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
                if (stuDelete != null)
                {
                    if (MessageBox.Show($"Bạn muốn xóa sinh viên {txtFullName.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        context.Students.Remove(stuDelete);
                        context.SaveChanges();
                        LoadData(); 
                        refresh();
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        txtStudentID.Enabled = true; 
                        btnAddOrUpdate.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        //------------------------------------------------------------------------
        //FORM REGISTRY
        private void đăngKýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }
        //------------------------------------------------------------------------
        //EXIT
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
