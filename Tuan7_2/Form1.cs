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

namespace Tuan7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveArray_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox nhập mảng
            string arrayInput = txtNhapMang.Text;

            // Kiểm tra nếu dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(arrayInput))
            {
                MessageBox.Show("Vui lòng nhập mảng.");
                return;
            }

            // Lưu dữ liệu vào file
            using (StreamWriter writer = new StreamWriter("array.txt"))
            {
                writer.WriteLine(arrayInput);
            }

            MessageBox.Show("Lưu mảng thành công.");
        }

        private void btnReadArray_Click(object sender, EventArgs e)
        {
            if (!File.Exists("array.txt"))
            {
                MessageBox.Show("File không tồn tại.");
                return;
            }

            using (StreamReader reader = new StreamReader("array.txt"))
            {
                // Đọc dữ liệu từ file và hiển thị lên TextBox "Nội dung đã lưu"
                txtNoiDungDaLuu.Text = reader.ReadLine();
            }

            MessageBox.Show("Đọc mảng thành công.");
        }
    }
}
