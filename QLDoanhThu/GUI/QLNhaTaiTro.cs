using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmQLNTT : Form
    {
        public frmQLNTT()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //-----------------------------------------------------------
        private void frmQL_NhaTaiTro_Load(object sender, EventArgs e)
        {
            try
            {
                dgvQLNTT.DataSource = modify.Table("Select MaNTT as [Mã], TenNTT as [Tên NTT], SoTienTT as [Số Tiền], NgayTT as [Ngày Tài Trợ], SDT as [TTLH], DiaChi as [Địa Chỉ] from NHATAITRO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            reset();
        }
        //-------------------------Tra Nguoc Du Lieu------------------------------------
        private void dgvQLNTT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLNTT.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLNTT.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtMaNTT.Text = dgvQLNTT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenNTT.Text = dgvQLNTT.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSoTien.Text = dgvQLNTT.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dateTimeNgayBD.Text = dgvQLNTT.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtTTLH.Text = dgvQLNTT.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtDiaChi.Text = dgvQLNTT.Rows[e.RowIndex].Cells[5].Value.ToString();
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
            if (txtMaNTT.Text == "" || txtTenNTT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            else if(txtTTLH.TextLength != 10)
            {
                MessageBox.Show("TTLH có 10 số!");
                return false;
            }
            return true;    //Du lieu dung
        }
        //Check da co ID hay chua
        private int CheckID(string ID)
        {
            int length = dgvQLNTT.Rows.Count;     //Dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvQLNTT.Rows[i].Cells[0].Value != null)
                    if (dgvQLNTT.Rows[i].Cells[0].Value.ToString() == ID)
                        return i;
            }
            return -1;
        }
        //INPUT ONLY NUMBER
        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTTLH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //-------------------------Reset-----------------------------------
        private void reset()
        {
            txtMaNTT.Clear();
            txtTenNTT.Clear();
            txtDiaChi.Clear();
            txtTTLH.Clear();
            txtSoTien.Clear();
            dateTimeNgayBD.Value.ToLocalTime();
            txtTimKiem.Clear();
        }
        //-------------------------UPDATE------------------------------------
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    if (CheckID(txtMaNTT.Text) == 1)     //-1 la  moi
                    {
                        string query = "UPDATE NHATAITRO SET MaNTT = N'" + txtMaNTT.Text + @"', TenNTT = N'" + txtTenNTT.Text + @"', DiaChi = N'" + txtDiaChi.Text + @"', SDT = N'" + txtTTLH.Text + @"', SoTienTT = " + txtSoTien.Text + @", NgayTT = '" + dateTimeNgayBD.Value.ToUniversalTime() + @"' WHERE (MaNTT = N'" + txtMaNTT.Text + @"')";
                        modify.Command(query);
                        reset();
                        frmQL_NhaTaiTro_Load(sender, e);
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string query = " INSERT INTO NHATAITRO VALUES (N'" + txtMaNTT.Text + "', N'" + txtTenNTT.Text + "', N'" + txtDiaChi.Text + "', N'" + txtTTLH.Text + "', " + txtSoTien.Text + ", '" + dateTimeNgayBD.Value.ToUniversalTime() + "')";
                        modify.Command(query);
                        reset();
                        frmQL_NhaTaiTro_Load(sender, e);
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
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
                if (MessageBox.Show($"Bạn muốn xóa sinh viên {txtMaNTT.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string query = " Delete FROM NHATAITRO Where(MaNTT = N'" + txtMaNTT.Text + "')";
                    modify.Command(query);
                    reset();
                    frmQL_NhaTaiTro_Load(sender, e);
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã Vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------SEARCH----------------------------------
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.Trim();
            if (search == "")
            {
                frmQL_NhaTaiTro_Load(sender, e);
            }
            else
            {
                string query = "Select * From NHATAITRO Where TenNTT Like N'%" + search + "%'";
                dgvQLNTT.DataSource = modify.Table(query);
            }
        }
    }
}
