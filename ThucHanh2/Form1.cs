using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form1 : Form
    {
        // Đơn giá
        private const int GIA_LAY_CAO_RANG = 50_000;     // /2 hàm (trọn gói)
        private const int GIA_TAY_TRANG    = 100_000;    // /2 hàm (trọn gói)
        private const int GIA_HAN_RANG     = 100_000;    // /1 răng
        private const int GIA_BE_RANG      = 10_000;     // /1 răng
        private const int GIA_BOC_RANG     = 1_000_000;  // /1 răng

        private readonly CultureInfo _vi = new CultureInfo("vi-VN");

        public Form1()
        {
            InitializeComponent();

            // gán sự kiện cho nút (phòng khi Designer chưa gán)
            btnTinhTien.Click += btnTinhTien_Click;
            btnThoat.Click    += btnThoat_Click;

            // bật/tắt input số lượng theo checkbox
            chkHanRang.CheckedChanged += (_, __) => numHanRang.Enabled = chkHanRang.Checked;
            chkBeRang.CheckedChanged  += (_, __) => numBeRang.Enabled  = chkBeRang.Checked;
            chkBocRang.CheckedChanged += (_, __) => numBocRang.Enabled = chkBocRang.Checked;

            // set trạng thái ban đầu theo tình trạng tick hiện tại (đúng hơn là ép false)
            numHanRang.Enabled = chkHanRang.Checked;
            numBeRang.Enabled  = chkBeRang.Checked;
            numBocRang.Enabled = chkBocRang.Checked;

            // validate tên KH
            txtTenKH.Validating += txtTenKH_Validating;

            // Enter để tính nhanh
            this.AcceptButton = btnTinhTien;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // kiểm tra tên KH (và các control có Validate nếu có)
            if (!ValidateChildren(ValidationConstraints.Enabled))
                return;

            long thanhTien = 0;

            if (chkLayCaoRang.Checked) thanhTien += GIA_LAY_CAO_RANG;
            if (chkTayTrang.Checked)   thanhTien += GIA_TAY_TRANG;

            if (chkHanRang.Checked) thanhTien += (long)numHanRang.Value * GIA_HAN_RANG;
            if (chkBeRang.Checked)  thanhTien += (long)numBeRang.Value  * GIA_BE_RANG;
            if (chkBocRang.Checked) thanhTien += (long)numBocRang.Value * GIA_BOC_RANG;

            txtThanhTien.Text = thanhTien.ToString("N0", _vi) + " đ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        // === Validation: tên khách hàng không được trống ===
        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                e.Cancel = true; // chặn rời control
                err.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }
    }
}
