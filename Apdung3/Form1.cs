using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Apdung3   // <--- đổi cho khớp project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // gán sự kiện (phòng khi Designer chưa gán)
            btnLogin.Click += btnLogin_Click;
            btnCancel.Click += (_, __) => this.Close();

            // Enter = Đăng nhập
            this.AcceptButton = btnLogin;

            // checkbox hiện/ẩn mật khẩu
            chkShowPass.CheckedChanged += (_, __) =>
                txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;

            // mặc định ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = true;

            // bật validate
            txtUser.Validating += txt_Validating_NotEmpty;
            txtPassword.Validating += txt_Validating_NotEmpty;
        }

        private void txt_Validating_NotEmpty(object sender, CancelEventArgs e)
        {
            var tb = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                err.SetError(tb, "Không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(tb, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // kiểm tra 2 ô đều hợp lệ
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            // TODO: ở đây mày có thể check tài khoản thực tế
            // ví dụ: if (txtUser.Text == "admin" && txtPassword.Text == "123")
            //        { DialogResult = DialogResult.OK; Close(); } else { MessageBox.Show(...); }

            MessageBox.Show(
                "Đăng nhập thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
