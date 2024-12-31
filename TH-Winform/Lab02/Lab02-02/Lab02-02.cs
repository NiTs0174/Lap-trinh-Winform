using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class dgvStudentID : Form
    {
        public dgvStudentID()
        {
            InitializeComponent();
        }
        private void dgvStudentID_Load(object sender, EventArgs e)
        {
            cmbFaculty.SelectedIndex = 0;
        }
        private int GetSelectedRow(string studentID)
        {
            try
            {
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                {
                    if (dgvStudent.Rows[i].Cells[0].Value != null)
                    {
                        if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                        {
                            return i;
                        }
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void InsertUpdate(int selectedRow)
        {
            try
            {
                dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
                dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
                dgvStudent.Rows[selectedRow].Cells[2].Value = optNu.Checked ? "Nữ" : "Nam";
                dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAvgScore.Text).ToString();
                dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAvgScore.Text == "") throw new Exception("Vui lòng nhập đầy đủ thông tin sinh viên!");
                int selectedRow = GetSelectedRow (txtStudentID.Text);
                if (selectedRow == -1)  //TH Them moi
                {
                    selectedRow = dgvStudent.Rows.Add();
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else                    //TH Cap nhat
                {
                    InsertUpdate(selectedRow);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                }

                sum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtStudentID.Text);
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy MSSV cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudent.Rows.RemoveAt(selectedRow);      //xoa thong tin sv tai dong tim thay
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //2.5
        private void sum()
        {
            int NamCount = 0;
            int NuCount = 0;
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value != null)
                {
                    if (dgvStudent.Rows[i].Cells[2].Value.ToString() == "Nam")
                    {
                        NamCount++;
                    }
                    else
                        NuCount++;
                }
            }
            txtTSVNam.Text = NamCount.ToString();
            txtTSVNu.Text = NuCount.ToString();
        }
        //2.4
        private void dgvStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtFullName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtAvgScore.Text = dgvStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    if (dgvStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nữ")
                        optNu.Checked = true;
                    else
                        optNam.Checked = true;
                    cmbFaculty.SelectedItem = dgvStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
