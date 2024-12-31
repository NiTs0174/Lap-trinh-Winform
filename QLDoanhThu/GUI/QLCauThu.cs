using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL.Entities;
using DAL;

namespace GUI
{
    public partial class frmQLCT : Form
    {
        private readonly DoiBongBUS doiBongSer = new DoiBongBUS();
        public frmQLCT()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //------------------------------------------------------
        private void QuanLiCauThu_Load(object sender, EventArgs e)
        {
            try
            {
                dgvQuanLiCauThu.DataSource = modify.Table("Select * from CAUTHU");
                var listTranDaus = doiBongSer.GetAll();
                FillDoiBongCombobox(listTranDaus);
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
            this.cmbTenDB.DataSource = listDoiBongs;
            this.cmbTenDB.DisplayMember = "TenDB";
            this.cmbTenDB.ValueMember = "MaDB";
        }
        //-------------------------------------------------------------------------------

        private void dgvQuanLiCauThu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQuanLiCauThu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQuanLiCauThu.CurrentRow.Selected = true;
                    txtMaCT.Text = dgvQuanLiCauThu.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenCT.Text = dgvQuanLiCauThu.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dateTimeNgaySinh.Text = dgvQuanLiCauThu.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNoiSinh.Text = dgvQuanLiCauThu.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cmbViTri.Text = dgvQuanLiCauThu.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cmbTenDB.SelectedValue = dgvQuanLiCauThu.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------
        private void DeleteTextBoxes()
        {
            txtMaCT.Text = "";
            cmbTenDB.Text = "";
            txtTenCT.Text = "";
            cmbViTri.Text = "";
            dateTimeNgaySinh.Text = "";
            txtNoiSinh.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtMaCT.Text == "") { MessageBox.Show("Mời Bạn Chọn Mã Cầu Thủ"); return false; }
            return true;
        }
        //----------------------------------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {

                string query = " INSERT INTO CAUTHU VALUES (N'" + txtMaCT.Text + "', N'" + txtTenCT.Text + "', '" + dateTimeNgaySinh.Value.ToUniversalTime() + "', N'" + txtNoiSinh.Text + "', N'" + cmbViTri.Text + "', N'" + cmbTenDB.SelectedValue.ToString() + "')";
                    try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm Thành Công!");
                        DeleteTextBoxes();
                        QuanLiCauThu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Thêm:" + ex.Message);
                }
            }
        }
        //--------------------SUA------------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {                
                string query = "UPDATE CAUTHU SET MaCT = N'" + txtMaCT.Text + @"', TenCT = N'" + txtTenCT.Text + @"',NgaySinh = '" + dateTimeNgaySinh.Value.ToUniversalTime() + @"', NoiSinh = N'" + txtNoiSinh.Text + @"', ViTri = N'" + cmbViTri.Text + @"', MaDB = N'" + cmbTenDB.SelectedValue.ToString() + @"' 
                                              WHERE (MaCT = N'" + txtMaCT.Text + @"')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn Sửa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa Thành Công!");
                        DeleteTextBoxes();
                        QuanLiCauThu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa:" + ex.Message);
                }
            }
        }
        //------------XOA--------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLiCauThu.Rows.Count > 1)
            {
                string query = " Delete FROM CAUTHU Where(MaCT = N'" + txtMaCT.Text + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn Xóa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa Thành Công!");
                        DeleteTextBoxes();
                        QuanLiCauThu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa:" + ex.Message);
                }
            }
        }
        //----------------------------TIM----------------------------
        private void txtTK_TextChanged(object sender, EventArgs e)
        {

            string search = txtTK.Text.Trim();
            if (search == "")
            {
                QuanLiCauThu_Load(sender, e);
            }
            else
            {
                string query = "Select * From CAUTHU Where TenCT Like N'%" + search + "%'";
                dgvQuanLiCauThu.DataSource = modify.Table(query);
            }
        }
    }
}

