using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;

namespace GUI
{
    public partial class frmQLTaiKhoan : Form
    {
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //------------------------------------------------------------------------
        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvQLTK.DataSource = modify.Table("Select TaiKhoan as [Tên Tài Khoản], TenNV as [Tên Nhân Viên], MatKhau as [Mật Khẩu], LoaiTK as [Loại Tài Khoản] from TAIKHOAN");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: ", ex.Message);
            }

        }
        //-------------------------Tra Nguoc Du Lieu------------------------------------
        private void dgvQLTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLTK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLTK.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtTenTK.Text = dgvQLTK.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenNV.Text = dgvQLTK.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMK.Text = dgvQLTK.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cmbLoaiTK.Text = dgvQLTK.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------CHECK------------------------------------
        //Check input data
        private bool CheckInput()
        {
            //KTTT day du hay chua
            if (txtTenTK.Text == "" || txtTenNV.Text == "" || txtMK.Text == "" || cmbLoaiTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;    //Du lieu dung
        }
        //Check da co ID hay chua
        private int CheckID(string ID)
        {
            int length = dgvQLTK.Rows.Count;     //Dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvQLTK.Rows[i].Cells[0].Value != null)
                    if (dgvQLTK.Rows[i].Cells[0].Value.ToString() == ID)
                        return i;
            }
            return -1;
        }

        //-------------------------RESET FORM-----------------------------------
        private void reset()
        {
            txtTenNV.Clear();
            txtTenTK.Clear();
            txtMK.Clear();
            cmbLoaiTK.Text = "";
        }
        //-------------------------UPDATE------------------------------------
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    if (CheckID(txtTenTK.Text) == 1)     //-1 la  moi
                    {
                        string query = "UPDATE TAIKHOAN SET TaiKhoan = N'" + txtTenTK.Text + "', TenNV = N'" + txtTenNV.Text + "', MatKhau = N'" + txtMK.Text + "', LoaiTK = N'" + cmbLoaiTK.Text + "' WHERE (TaiKhoan = N'" + txtTenTK.Text + @"')";
                        modify.Command(query);
                        reset();
                        frmQLTaiKhoan_Load(sender, e);
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string query = " INSERT INTO TAIKHOAN VALUES (N'" + txtTenTK.Text + "', N'" + txtTenNV.Text + "', N'" + txtMK.Text + "', N'" + cmbLoaiTK.Text + "')";
                        modify.Command(query);
                        reset();
                        frmQLTaiKhoan_Load(sender, e);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------DELETE------------------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLTK.Rows.Count > 1)
                {
                    if (MessageBox.Show($"Bạn muốn xóa {txtTenTK.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string query = " Delete FROM TAIKHOAN Where(TaiKhoan = N'" + txtTenTK.Text + "')";
                        modify.Command(query);
                        reset();
                        frmQLTaiKhoan_Load(sender, e);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
