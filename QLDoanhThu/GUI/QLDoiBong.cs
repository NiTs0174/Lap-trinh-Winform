using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DAL;

namespace GUI
{
    public partial class frmQLDB : Form
    {
        public frmQLDB()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        //------------------------FORM LOAD--------------------------------
        private void QuanLiDoiBong_Load(object sender, EventArgs e)
        {
            try
            {
                dgvQuanLiDoiBong.DataSource = modify.Table("Select * from DOIBONG");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :" + ex.Message);
            }
            DeleteTextBoxes();
        }
        //-----------------------------------------TRA NGUOC----------------------------------------------
        private void dgvQuanLiDoiBong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQuanLiDoiBong.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    txtMaDB.Text = dgvQuanLiDoiBong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenDB.Text = dgvQuanLiDoiBong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtDC.Text = dgvQuanLiDoiBong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtTTLH.Text = dgvQuanLiDoiBong.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------
        private void DeleteTextBoxes()
        {
            txtMaDB.Text = "";
            txtTenDB.Text = "";
            txtDC.Text = "";
            txtTTLH.Text = "";
        }
        //-----------------------------
        private bool CheckTextBoxes()
        {
            if (txtMaDB.Text == "") { MessageBox.Show("Mời Bạn Chọn Mã Đội Bóng"); return false; }
            return true;
        }
        //----------------------THEM-----------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                string query = " INSERT INTO DOIBONG VALUES (N'" + txtMaDB.Text + "',N'" + txtTenDB.Text + "',N'" + txtDC.Text + "',N'" + txtTTLH.Text + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn thêm vào không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Thêm Thành Công!");
                        DeleteTextBoxes();
                        QuanLiDoiBong_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Thêm:" + ex.Message);
                }
            }
        }
        //----------------------SUA----------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                //GetValuesTextBoxes();
                string query = "UPDATE DOIBONG SET MaDB = N'" + txtMaDB.Text + @"', TenDB = N'" + txtTenDB.Text + @"', DiaChi = N'" + txtDC.Text + @"',TTLH = N'" + txtTTLH.Text + @"' WHERE (MaDB = N'" + txtMaDB.Text + @"')";

                try
                {
                    if (MessageBox.Show("Bạn có muốn Sửa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa Thành Công!");
                        DeleteTextBoxes();
                        QuanLiDoiBong_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Sửa:" + ex.Message);
                }
            }
        }
        //---------------------XOA----------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLiDoiBong.Rows.Count > 1)
            {

                string query = " Delete FROM DOIBONG Where(MaDB = N'" + txtMaDB.Text + "')";
                try
                {
                    if (MessageBox.Show("Bạn có muốn Xóa không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa Thành Công!");
                        DeleteTextBoxes();
                        QuanLiDoiBong_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa:" + ex.Message);
                }
            }
        }
        //----------------------TIM--------------------------------
        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string search = txtTK.Text.Trim();
            if (search == "")
            {
                QuanLiDoiBong_Load(sender, e);
            }
            else
            {
                string query = "Select * From DOIBONG Where TenDB Like N'%" + search + "%'";
                dgvQuanLiDoiBong.DataSource = modify.Table(query);
            }
        }
    }
}

