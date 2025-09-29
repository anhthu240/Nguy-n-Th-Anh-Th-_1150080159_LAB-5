using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1_LAB5._2_
{
    public partial class Form1 : Form
    {
        private readonly CultureInfo _ci = CultureInfo.InvariantCulture;

        public Form1()
        {
            InitializeComponent();            // do Designer sinh
            if (txtKetQua != null) txtKetQua.ReadOnly = true;

            // Nếu trong Designer CHƯA gán Click cho các nút,
            // bạn có thể mở comment 6 dòng bên dưới:
            // btnCong.Click  += btnCong_Click;
            // btnTru.Click   += btnTru_Click;
            // btnNhan.Click  += btnNhan_Click;
            // btnChia.Click  += btnChia_Click;
            // btnXoa.Click   += btnXoa_Click;
            // btnThoat.Click += btnThoat_Click;
        }

        // --- Helpers ---
        private bool TryGetInputs(out double a, out double b)
        {
            // chấp nhận cả dấu phẩy hoặc chấm
            string sa = txtA.Text.Trim().Replace(',', '.');
            string sb = txtB.Text.Trim().Replace(',', '.');

            bool okA = double.TryParse(sa, NumberStyles.Float, _ci, out a);
            bool okB = double.TryParse(sb, NumberStyles.Float, _ci, out b);

            if (!okA || !okB)
            {
                MessageBox.Show("Vui lòng nhập số thực hợp lệ cho a và b!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // --- Event handlers (hãy gán Click của các nút về các hàm này) ---
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
                txtKetQua.Text = (a + b).ToString(_ci);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
                txtKetQua.Text = (a - b).ToString(_ci);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double a, out double b))
                txtKetQua.Text = (a * b).ToString(_ci);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b)) return;

            if (b == 0)
            {
                MessageBox.Show("Mẫu số không được bằng 0. Nhập lại!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtB.SelectAll();
                txtB.Focus();
                return;
            }

            txtKetQua.Text = (a / b).ToString(_ci);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
