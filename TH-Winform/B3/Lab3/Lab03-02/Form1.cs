using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                //richText.ForeColor = fontDlg.Color;
                //richText.Font = fontDlg.Font;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click của menu "Exit"
            Application.Exit(); // Thoát khỏi ứng dụng
        }

        //foreach (FontFamily font in new InstalledFontCollection().Families){
        //   cmbFonts.Items.Add(font.Name); 
        //}
    }
}
