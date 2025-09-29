using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Apdung2  
{
    public partial class Form1 : Form
    {
        // map password -> tên nhóm
        private readonly Dictionary<string, string> _passToGroup = new Dictionary<string, string>
        {
            { "1496", "Phát triển công nghệ" },
            { "2673", "Phát triển công nghệ" },
            { "7462", "Nghiên cứu viên"      },
            { "8884", "Thiết kế mô hình"    },
            { "3842", "Thiết kế mô hình"    },
            { "3383", "Thiết kế mô hình"    },
        };

        public Form1()
        {
            InitializeComponent();
        }

        /* ====== EVENTS ====== */
        private void btnNum_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            // giới hạn 4 số cho pass (theo ví dụ)
            if (txtPassword.TextLength < 4)
                txtPassword.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text.Trim();
            string group = ResolveGroup(pass);

            string result = group == null ? "Từ chối!" : "Chấp nhận!";
            if (group == null) group = "Không có";

            // log
            dgvLog.Rows.Add(DateTime.Now.ToString("g"), group, result);

            // feedback nhẹ
            if (result == "Chấp nhận!")
                SystemSounds.Asterisk.Play();
            else
                SystemSounds.Hand.Play();

            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Chuông báo kêu!", "RING", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /* ====== HELPERS ====== */
        private string ResolveGroup(string pass)
        {
            if (string.IsNullOrWhiteSpace(pass)) return null;
            return _passToGroup.TryGetValue(pass, out var grp) ? grp : null;
        }
    }
}
