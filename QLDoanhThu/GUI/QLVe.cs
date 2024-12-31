
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DAL.Entities;

namespace GUI
{
    public partial class frmQLVe : Form
    {
        private readonly TranDauBUS tranDauSer = new TranDauBUS();
        public frmQLVe()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();        
        //-------------------------------------------------------------
        private void QL_Ticket_Load(object sender, EventArgs e)
        {
            try
            {
                dgvQLVe.DataSource = modify.Table("Select MaVe as [Mã Vé], MaTD as [Mã Trận Đấu], GiaVe as [Giá Vé], SLVeDaBan as [Số Lượng Vé Đã Bán] from VE");
                var listTranDaus = tranDauSer.GetAll();
                FillTranDauCombobox(listTranDaus);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }
        //------------------------------------------------------------------------
        private void FillTranDauCombobox(List<TRANDAU> listTranDaus)
        {
            this.cmbMaTD.DataSource = listTranDaus;
            this.cmbMaTD.DisplayMember = "MaTD";
            this.cmbMaTD.ValueMember = "MaTD";
        }
        //-------------------------Tra Nguoc Du Lieu------------------------------------
        private void dgvQLVe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLVe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLVe.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtMaVe.Text = dgvQLVe.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmbMaTD.Text = dgvQLVe.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGiaVe.Text = dgvQLVe.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtSLVe.Text = dgvQLVe.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            if (txtMaVe.Text == "" || cmbMaTD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;    //Du lieu dung
        }
        //INPUT ONLY NUMBER
        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSLVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Check da co ID hay chua
        private int CheckID(string ID)
        {
            int length = dgvQLVe.Rows.Count;     //Dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvQLVe.Rows[i].Cells[0].Value != null)
                    if (dgvQLVe.Rows[i].Cells[0].Value.ToString() == ID)
                        return i;
            }
            return -1;
        }
        //-------------------------RESET FORM-----------------------------------
        private void reset()
        {
            txtMaVe.Clear();
            txtGiaVe.Clear();
            txtSLVe.Clear();
            cmbMaTD.Text = "";
        }
        //-------------------------UPDATE------------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    if (CheckID(txtMaVe.Text) == 1)     //-1 la  moi
                    {
                        string query = "UPDATE VE SET MaVe = N'" + txtMaVe.Text + @"', MaTD = N'" + cmbMaTD.SelectedValue.ToString() + @"', GiaVe = " + txtGiaVe.Text + @", SLVeDaBan = " + txtSLVe.Text + @" WHERE (MaVe = N'" + txtMaVe.Text + @"')";
                        modify.Command(query);
                        reset();
                        QL_Ticket_Load(sender, e);
                        MessageBox.Show("Cập nhật thành công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string query = " INSERT INTO VE VALUES (N'" + txtMaVe.Text + "', N'" + cmbMaTD.SelectedValue.ToString() + "', " + txtGiaVe.Text + ", " + txtSLVe.Text + ")";
                        modify.Command(query);
                        reset();
                        QL_Ticket_Load(sender, e);                        
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
                if (dgvQLVe.Rows.Count > 1)
                {
                    if (MessageBox.Show($"Bạn muốn xóa {txtMaVe.Text}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        string query = " Delete FROM VE Where(MaVe = N'" + txtMaVe.Text + "')";
                        modify.Command(query);
                        reset();
                        QL_Ticket_Load(sender, e);
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
        //---------------------------SEARCH----------------------------------
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = txtTimKiem.Text.Trim();
                if (search == "")
                {
                    QL_Ticket_Load(sender, e);
                }
                else
                {
                    string query = "Select * From VE Where MaVe Like N'%" + search + "%'";
                    dgvQLVe.DataSource = modify.Table(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //------------------REPORT----------------------------
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmDoanhThu doanhThu = new frmDoanhThu();
            doanhThu.ShowDialog();
        }
    }
}
