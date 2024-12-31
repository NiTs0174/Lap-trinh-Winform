using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab06_KT.Models;
using System.Data.Entity.Migrations;
using System.Runtime.Remoting.Contexts;

namespace Lab06_KT
{
    public partial class Form1 : Form
    {
        Model1 context = new Model1();
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<TinhTrang> listTinhTrangs = context.TinhTrangs.ToList(); //lấy các khoa
                List<BenhNhan> listBenhNhans = context.BenhNhans.ToList(); //lấy sinh viên
                FillTinhTrangCombobox(listTinhTrangs);
                FillLayNhiemTuCombobox(listBenhNhans);
                BindGrid(listBenhNhans);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //------------------------------------------------------------------------
        private void FillTinhTrangCombobox(List<TinhTrang> listTinhTrangs)
        {
            listTinhTrangs.Insert(0, new TinhTrang());
            this.cmbTinhTrang.DataSource = listTinhTrangs;
            this.cmbTinhTrang.DisplayMember = "TenTT";
            this.cmbTinhTrang.ValueMember = "MaTT";
        }
        private void FillLayNhiemTuCombobox(List<BenhNhan> listBenhNhans)
        {
            listBenhNhans.Insert(0, new BenhNhan());
            this.cmbLayNhiemTu.DataSource = listBenhNhans;
            this.cmbLayNhiemTu.DisplayMember = "MaBN";
            this.cmbLayNhiemTu.ValueMember = "MaBN";
        }
        //------------------------------------------------------------------------
        private void BindGrid(List<BenhNhan> listBenhNhans)
        {
            dgvQLBN.Rows.Clear();
            foreach (var item in listBenhNhans)
            {
                int index = dgvQLBN.Rows.Add();
                dgvQLBN.Rows[index].Cells[0].Value = item.MaBN;
                dgvQLBN.Rows[index].Cells[1].Value = item.TenBN;
                if (item.TinhTrang != null)
                    dgvQLBN.Rows[index].Cells[2].Value = item.TinhTrang.TenTT;
                //Tim F
            }
        }
        //------------------------------------------------------------------------
        //TRA NGUOC DU LIEU
        private void dgvQLBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLBN.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLBN.CurrentRow.Selected = true;  //Lay dong hien tai
                    txtMaBN.Text = dgvQLBN.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenBN.Text = dgvQLBN.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbTinhTrang.Text = dgvQLBN.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //rtxtGhiChu.Text
                    //cmbLayNhiemTu.Text
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------
        //UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (CheckID(txtMaBN.Text) == 1)
                {
                    BenhNhan updateBN = context.BenhNhans.FirstOrDefault(p => p.MaBN == txtMaBN.Text);
                    if (updateBN != null)
                    {
                        updateBN.TenBN = txtTenBN.Text.Trim();
                        context.BenhNhans.AddOrUpdate(updateBN);
                        context.SaveChanges();
                        loadData(); loadForm();
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    BenhNhan addBN = new BenhNhan();
                    {
                        addBN.MaBN = txtMaBN.Text;
                        addBN.TenBN = txtTenBN.Text;
                        addBN.MaTT = Convert.ToInt32(cmbTinhTrang.SelectedValue.ToString());
                        addBN.GhiChu = rtxtGhiChu.Text;
                        //addBN.BNTXG = cmbTinhTrang.Text;
                    };
                    context.BenhNhans.AddOrUpdate(addBN);
                    context.SaveChanges();
                    loadData();
                    loadForm();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        } 
        //------------------------------------------------------------------------
        //CHECK DATA
        private bool CheckData()
        {
            //KTTT day du hay chua
            if (txtMaBN.Text == "" || txtTenBN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân!");
                return false;
            }
            // Kiểm tra mã số có 6 kí tự hay không
            else if (txtMaBN.Text.Length != 6)
            {
                MessageBox.Show("Mã số bệnh nhân phải có 6 kí tự!");
                return false;
            }
            return true;    //Du lieu dung
        }
        //------------------------------------------------------------------------
        //Check da co StudentID hay chua
        private int CheckID(string StudentID)
        {
            int length = dgvQLBN.Rows.Count;     //Dem so dong trong dgv
            for (int i = 0; i < length; i++)
            {
                if (dgvQLBN.Rows[i].Cells[0].Value != null)
                    if (dgvQLBN.Rows[i].Cells[0].Value.ToString() == txtMaBN.Text)
                        return i;
            }
            return -1;
        }
        //------------------------------------------------------------------------
        //Load DATA
        private void loadData()
        {
            List<BenhNhan> newListBenhNhan = context.BenhNhans.ToList();   //Lay DS moi tu DB
            BindGrid(newListBenhNhan);
        }
        //------------------------------------------------------------------------
        //LOAD FORM
        private void loadForm()
        {
            txtMaBN.Clear();
            txtTenBN.Clear();
            rtxtGhiChu.Clear();
        }
        //------------------------------------------------------------------------
        //FORM TRUY VET
        private void truyVếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        //------------------------------------------------------------------------
        //EXIT
        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
