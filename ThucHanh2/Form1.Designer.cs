namespace ThucHanh2
{
    partial class Form1
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>Method required for Designer support.</summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);

            this.groupDichVu = new System.Windows.Forms.GroupBox();
            this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.lblGiaLayCao = new System.Windows.Forms.Label();
            this.lblGiaTayTrang = new System.Windows.Forms.Label();
            this.lblGiaHan = new System.Windows.Forms.Label();
            this.lblGiaBe = new System.Windows.Forms.Label();
            this.lblGiaBoc = new System.Windows.Forms.Label();
            this.numHanRang = new System.Windows.Forms.NumericUpDown();
            this.numBeRang = new System.Windows.Forms.NumericUpDown();
            this.numBocRang = new System.Windows.Forms.NumericUpDown();

            this.groupChucNang = new System.Windows.Forms.GroupBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).BeginInit();

            this.SuspendLayout();

            // ===== Form =====
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 461);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            // this.Load += new System.EventHandler(this.Form1_Load);

            // ===== Title =====
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 44;
            this.lblTitle.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.ForeColor = System.Drawing.Color.White;

            // ===== Tên KH =====
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(16, 60);
            this.lblTen.Text = "Tên khách hàng:";
            this.txtTenKH.Location = new System.Drawing.Point(128, 57);
            this.txtTenKH.Size = new System.Drawing.Size(420, 23);
            this.txtTenKH.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // ErrorProvider
            this.err.ContainerControl = this;

            // ===== Group Dịch vụ =====
            this.groupDichVu.Text = "Dịch vụ tại phòng khám:";
            this.groupDichVu.Location = new System.Drawing.Point(16, 95);
            this.groupDichVu.Size = new System.Drawing.Size(649, 200);
            this.groupDichVu.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            int leftChk = 24, leftGia = 260, leftNum = 560, top0 = 28, line = 28;

            // Lấy cao răng
            this.chkLayCaoRang.Location = new System.Drawing.Point(leftChk, top0 + line * 0);
            this.chkLayCaoRang.Text = "Lấy cao răng";
            this.lblGiaLayCao.Location = new System.Drawing.Point(leftGia, top0 + line * 0 + 3);
            this.lblGiaLayCao.Text = "50.000đ/2 hàm";

            // Tẩy trắng
            this.chkTayTrang.Location = new System.Drawing.Point(leftChk, top0 + line * 1);
            this.chkTayTrang.Text = "Tẩy trắng răng";
            this.lblGiaTayTrang.Location = new System.Drawing.Point(leftGia, top0 + line * 1 + 3);
            this.lblGiaTayTrang.Text = "100.000đ/2 hàm";

            // Hàn răng
            this.chkHanRang.Location = new System.Drawing.Point(leftChk, top0 + line * 2);
            this.chkHanRang.Text = "Hàn răng";
            this.lblGiaHan.Location = new System.Drawing.Point(leftGia, top0 + line * 2 + 3);
            this.lblGiaHan.Text = "100.000đ/1 răng";
            this.numHanRang.Location = new System.Drawing.Point(leftNum, top0 + line * 2 - 2);
            this.numHanRang.Minimum = 0; this.numHanRang.Maximum = 100; this.numHanRang.Value = 1;

            // Bể răng
            this.chkBeRang.Location = new System.Drawing.Point(leftChk, top0 + line * 3);
            this.chkBeRang.Text = "Bể răng";
            this.lblGiaBe.Location = new System.Drawing.Point(leftGia, top0 + line * 3 + 3);
            this.lblGiaBe.Text = "10.000đ/1 răng";
            this.numBeRang.Location = new System.Drawing.Point(leftNum, top0 + line * 3 - 2);
            this.numBeRang.Minimum = 0; this.numBeRang.Maximum = 100; this.numBeRang.Value = 1;

            // Bọc răng
            this.chkBocRang.Location = new System.Drawing.Point(leftChk, top0 + line * 4);
            this.chkBocRang.Text = "Bọc răng";
            this.lblGiaBoc.Location = new System.Drawing.Point(leftGia, top0 + line * 4 + 3);
            this.lblGiaBoc.Text = "1.000.000đ/1 răng";
            this.numBocRang.Location = new System.Drawing.Point(leftNum, top0 + line * 4 - 2);
            this.numBocRang.Minimum = 0; this.numBocRang.Maximum = 100; this.numBocRang.Value = 1;

            this.groupDichVu.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.chkLayCaoRang, this.lblGiaLayCao,
                this.chkTayTrang,   this.lblGiaTayTrang,
                this.chkHanRang,    this.lblGiaHan, this.numHanRang,
                this.chkBeRang,     this.lblGiaBe,  this.numBeRang,
                this.chkBocRang,    this.lblGiaBoc, this.numBocRang
            });

            // ===== Group Chức năng =====
            this.groupChucNang.Text = "Chức năng:";
            this.groupChucNang.Location = new System.Drawing.Point(16, 305);
            this.groupChucNang.Size = new System.Drawing.Size(649, 90);
            this.groupChucNang.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Location = new System.Drawing.Point(24, 34);
            this.btnTinhTien.Size = new System.Drawing.Size(100, 30);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(140, 34);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);

            this.lblThanhTien.Text = "Thành tiền:";
            this.lblThanhTien.Location = new System.Drawing.Point(280, 40);

            this.txtThanhTien.Location = new System.Drawing.Point(360, 36);
            this.txtThanhTien.Size = new System.Drawing.Size(260, 23); // rộng để không bị che số
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtThanhTien.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            this.groupChucNang.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnTinhTien, this.btnThoat, this.lblThanhTien, this.txtThanhTien
            });

            // ===== Add all to Form =====
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.groupDichVu);
            this.Controls.Add(this.groupChucNang);

            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHanRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBocRang)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        // ===== Fields (controls) =====
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ErrorProvider err;

        private System.Windows.Forms.GroupBox groupDichVu;
        private System.Windows.Forms.CheckBox chkLayCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.Label lblGiaLayCao;
        private System.Windows.Forms.Label lblGiaTayTrang;
        private System.Windows.Forms.Label lblGiaHan;
        private System.Windows.Forms.Label lblGiaBe;
        private System.Windows.Forms.Label lblGiaBoc;
        private System.Windows.Forms.NumericUpDown numHanRang;
        private System.Windows.Forms.NumericUpDown numBeRang;
        private System.Windows.Forms.NumericUpDown numBocRang;

        private System.Windows.Forms.GroupBox groupChucNang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}
