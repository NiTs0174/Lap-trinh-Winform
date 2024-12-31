using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", 
        DateTime.Now.ToString("dd/mm/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)    //Xử lý menu Open sử dụng OpenFileDialog
        {
            //Tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            //Lộc hiển thị các loại file
            dlg.Filter = "AVI file| *.avi | MPEG File | *.mpeg | Wav File | *.Wav | Midi File | *.midi | MP4 File | *.mp4 | MP3 File | *.mp3";
            //hien thi openDialog
            if (dlg.ShowDialog() == DialogResult.OK )
                axWindowsMediaPlayer1.URL = dlg.FileName;   //Lấy tên file cần mở
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của menu "Exit"
            Application.Exit(); // Thoát khỏi ứng dụng
        }
    }
}
