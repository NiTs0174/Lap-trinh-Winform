using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của menu "Insert"

            // Tạo một thể hiện mới của Form nhập liệu
            Form2 insertForm = new Form2();

            // Hiển thị Form nhập liệu
            insertForm.ShowDialog();
        }
        /*public partial class Form2 : Form
        {
            public Form2()
            {
                InitializeComponent();
            }

            // Các thành phần của Form nhập liệu (labels, textboxes, buttons, etc.) sẽ được thêm ở đây.
        }*/
    }
}
