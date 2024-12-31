using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            cmbFonts.SelectedIndexChanged += new EventHandler(cmbFonts_SelectedIndexChanged);

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
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        //2.1
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                cmbFonts.Items.Add(fontFamily.Name);
            }
            // Đặt font mặc định cho ComboBox (chẳng hạn "Tahoma")
            cmbFonts.SelectedItem = "Tahoma"; // Bạn có thể chọn bất kỳ font mặc định nào bạn muốn
        }
        //2.2
        private void menuNew_Click(object sender, EventArgs e)
        {
            richText.Clear();
            cmbFonts.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";
        }

        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên font được chọn từ ComboBox
            string selectedFontName = cmbFonts.SelectedItem.ToString();

            // Lấy kích thước font hiện tại của RichTextBox
            float currentFontSize = richText.Font.Size;

            // Tạo một font mới với tên font được chọn và kích thước font hiện tại
            Font newFont = new Font(selectedFontName, currentFontSize);

            // Đặt font mới cho toàn bộ văn bản trong RichTextBox
            richText.Font = newFont;
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Tệp văn bản|*.txt;*.rtf|Tất cả các tệp|*.*"; // Chỉ cho phép tập tin văn bản (*.txt hoặc *.rtf)

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                string fileExtension = Path.GetExtension(filePath);


                if (fileExtension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // Đọc nội dung từ tệp .txt và hiển thị trong RichTextBox
                    richText.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension.Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    // Đọc nội dung từ tệp .rtf và hiển thị trong RichTextBox
                    richText.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // Xử lý trường hợp tệp không được hỗ trợ
                    MessageBox.Show("Loại tệp không được hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            richText.Clear();
            cmbFonts.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";
        }


        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Thiết lập bộ lọc tệp cho SaveFileDialog để chỉ cho phép tập tin văn bản (*.txt hoặc *.rtf)
            saveFileDialog1.Filter = "Tệp văn bản (*.txt;*.rtf)|*.txt;*.rtf|Tất cả các tệp (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1; // Mặc định chọn bộ lọc đầu tiên (văn bản)
            saveFileDialog1.RestoreDirectory = true; // Khôi phục thư mục trước đó khi lưu tập tin

            // Hiển thị hộp thoại lưu tập tin và kiểm tra nếu người dùng đã chọn một vị trí lưu
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến tệp mà người dùng muốn lưu
                string filePath = saveFileDialog1.FileName;

                // Kiểm tra phần mở rộng của tệp để xác định loại tệp (txt hoặc rtf)
                string fileExtension = Path.GetExtension(filePath);

                if (fileExtension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // Lưu nội dung từ RichTextBox vào tệp .txt
                    richText.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension.Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    // Lưu nội dung từ RichTextBox vào tệp .rtf
                    richText.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // Xử lý trường hợp tệp không được hỗ trợ
                    MessageBox.Show("Loại tệp không được hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Thiết lập bộ lọc tệp cho SaveFileDialog để chỉ cho phép tập tin văn bản (*.txt hoặc *.rtf)
            saveFileDialog1.Filter = "Tệp văn bản (*.txt;*.rtf)|*.txt;*.rtf|Tất cả các tệp (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1; // Mặc định chọn bộ lọc đầu tiên (văn bản)
            saveFileDialog1.RestoreDirectory = true; // Khôi phục thư mục trước đó khi lưu tập tin

            // Hiển thị hộp thoại lưu tập tin và kiểm tra nếu người dùng đã chọn một vị trí lưu
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến tệp mà người dùng muốn lưu
                string filePath = saveFileDialog1.FileName;

                // Kiểm tra phần mở rộng của tệp để xác định loại tệp (txt hoặc rtf)
                string fileExtension = Path.GetExtension(filePath);

                if (fileExtension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    // Lưu nội dung từ RichTextBox vào tệp .txt
                    richText.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                else if (fileExtension.Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    // Lưu nội dung từ RichTextBox vào tệp .rtf
                    richText.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // Xử lý trường hợp tệp không được hỗ trợ
                    MessageBox.Show("Loại tệp không được hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Bold)
            {
                // Nếu vùng văn bản không chứa văn bản in đậm, thêm in đậm.
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                // Nếu vùng văn bản đã được in đậm, bỏ in đậm.
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Italic)
            {
                // Nếu vùng văn bản không chứa văn bản in đậm, thêm in đậm.
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                // Nếu vùng văn bản đã được in đậm, bỏ in đậm.
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Underline)
            {
                // Nếu vùng văn bản không chứa văn bản in đậm, thêm in đậm.
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                // Nếu vùng văn bản đã được in đậm, bỏ in đậm.
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị kích cỡ được chọn từ ComboBox.
            int selectedSize;
            if (int.TryParse(cmbSize.SelectedItem.ToString(), out selectedSize))
            {
                // Tạo một Font mới với kích cỡ đã chọn.
                System.Drawing.Font newFont = new System.Drawing.Font(richText.Font.FontFamily, selectedSize, richText.Font.Style);

                // Gán Font mới cho vùng văn bản đang được chọn trong RichTextBox.
                richText.SelectionFont = newFont;
            }
        }
    }
}
