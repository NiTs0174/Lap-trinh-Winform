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
using DAL.Entities;

namespace GUI
{
    public partial class frmTranDau : Form
    {
        private readonly DoiBongBUS doiBongSer = new DoiBongBUS();
        public frmTranDau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //---------------------------
        private void QuanLiTD1_Load(object sender, EventArgs e)
        {
            try
            {
                dgvQuanLiThiDau.DataSource = modify.Table("Select * from TRANDAU");
                var listDoiBongs = doiBongSer.GetAll();
                FillDoiBongCombobox(listDoiBongs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            DeleteTextBoxes();
        }
        private void FillDoiBongCombobox(List<DOIBONG> listDoiBongs)
        {
            //listDoiBongs.Insert(0, new DOIBONG());
            this.cmbMaDB.DataSource = listDoiBongs;
            this.cmbMaDB.DisplayMember = "TenDB";
            this.cmbMaDB.ValueMember = "MaDB";
        }
        //--------------------------------------------------
        private void dgvQuanLiThiDau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQuanLiThiDau.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQuanLiThiDau.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtMaTD.Text = dgvQuanLiThiDau.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmbMaDB.Text = dgvQuanLiThiDau.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dateTime_NgayTD.Text = dgvQuanLiThiDau.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtGioTD.Text = dgvQuanLiThiDau.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cmbSVD.Text = dgvQuanLiThiDau.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------
        private void DeleteTextBoxes()
        {
            txtMaTD.Text = "";
            cmbMaDB.Text = "";
            dateTime_NgayTD.Text = "";
            txtGioTD.Text = "";
            cmbSVD.Text = "";
        }     
        private bool CheckTextBoxes()
        {
            if (txtMaTD.Text == "") { MessageBox.Show("Mời Bạn Nhập Mã Trận Đấu"); return false; }
            return true;
        }
        //-----------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
               string query = " INSERT INTO TRANDAU VALUES (N'" + txtMaTD.Text + "', N'" + cmbMaDB.SelectedValue.ToString() + "', '" + dateTime_NgayTD.Value.ToUniversalTime() + "', N'" + txtGioTD.Text + "', N'" + cmbSVD.Text + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm Thành Công!");
                        DeleteTextBoxes();
                        QuanLiTD1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Thêm:" + ex.Message);
                }
            }
        }
        //--------------------------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                string query = "UPDATE TRANDAU SET MaTD = N'" + txtMaTD.Text + @"', MaDB = N'" + cmbMaDB.SelectedValue.ToString() + @"', NgayTD = '" + dateTime_NgayTD.Value.ToUniversalTime() + @"', GioTD = N'" + txtGioTD.Text + @"', SVD = N'" + cmbSVD.Text + "' WHERE (MaTD = N'" + txtMaTD.Text + @"')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn Sửa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa Thành Công!");
                        DeleteTextBoxes();
                        QuanLiTD1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa:" + ex.Message);
                }
            }
        }
        //-----------------------XOA---------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLiThiDau.Rows.Count > 1)
            {                
                string query = " Delete FROM TRANDAU Where(MaTD = N'" + txtMaTD.Text + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn Xóa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa Thành Công!");
                        DeleteTextBoxes();
                        QuanLiTD1_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa:" + ex.Message);
                }
            }
        }
        //----------------------TIM----------------------------
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text.Trim();
            if (search == "")
            {
                QuanLiTD1_Load(sender, e);
            }
            else
            {
                string query = "Select * From TRANDAU Where MaTD Like '%" + search + "%'";
                dgvQuanLiThiDau.DataSource = modify.Table(query);
            }
        }
    }
}
