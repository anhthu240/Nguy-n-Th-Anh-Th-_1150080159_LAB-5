using System;
using System.Windows.Forms;

namespace Apdung1   // <-- PHẢI trùng 100% với Designer
{
    public partial class Form1 : Form   // <-- partial + : Form
    {
        public Form1()
        {
            InitializeComponent();      // do Designer sinh
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out int a, out int b)) return;

            if (!rdoUSCLN.Checked && !rdoBSCNN.Checked)
            {
                MessageBox.Show("Vui lòng chọn USCLN hoặc BSCNN.",
                    "Thiếu lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rdoUSCLN.Checked)
                txtKetQua.Text = Gcd(a, b).ToString();
            else
                txtKetQua.Text = Lcm(a, b).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        // ===== Helpers =====
        private bool TryGetInputs(out int a, out int b)
        {
            bool okA = int.TryParse(txtA.Text.Trim(), out a);
            bool okB = int.TryParse(txtB.Text.Trim(), out b);

            if (!okA || !okB)
            {
                MessageBox.Show("Nhập hai số NGUYÊN hợp lệ (a, b).",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int Gcd(int x, int y) // Euclid, cho phép số âm
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while (y != 0)
            {
                int r = x % y;
                x = y; y = r;
            }
            return x; // nếu a=b=0 => 0
        }

        private long Lcm(int x, int y) // BCNN = |a*b|/UCLN, nếu có 0 => 0
        {
            long ax = Math.Abs((long)x), ay = Math.Abs((long)y);
            if (ax == 0 || ay == 0) return 0;
            int g = Gcd(x, y);
            return (ax / g) * ay; // chia trước tránh tràn
        }
    }
}
