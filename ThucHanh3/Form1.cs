using System;
using System.Windows.Forms;

namespace ThucHanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        // Nhập số vào ListBox
        private void btnInput_Click(object sender, EventArgs e)
        {
            int a;
            string num = txtInput.Text.Trim();
            if (int.TryParse(num, out a))
            {
                lsbDaySo.Items.Add(a);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không phải số nguyên! Hãy nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        // Tăng mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
                lsbDaySo.Items[i] = (int)lsbDaySo.Items[i] + 2;
        }

        // Chọn số chẵn đầu tiên
        private void btnChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if ((int)lsbDaySo.Items[i] % 2 == 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        // Chọn số lẻ cuối cùng
        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if ((int)lsbDaySo.Items[i] % 2 != 0)
                {
                    lsbDaySo.SelectedIndex = i;
                    break;
                }
            }
        }

        // Xóa phần tử đang chọn
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex != -1)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            else
                MessageBox.Show("Bạn chưa chọn số cần xóa!", "Thông báo");
        }

        // Xóa phần tử đầu
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(0);
        }

        // Xóa phần tử cuối
        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }

        // Xóa dãy số
        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        // Thoát ứng dụng
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
