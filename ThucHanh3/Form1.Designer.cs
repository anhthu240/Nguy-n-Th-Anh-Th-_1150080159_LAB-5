namespace ThucHanh3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();

            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();

            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ===== Form =====
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng xử lý dãy số";

            // ===== Title =====
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Height = 50;

            // ===== Nhập số =====
            this.lblNhap.Text = "Nhập số nguyên:";
            this.lblNhap.Location = new System.Drawing.Point(20, 70);
            this.lblNhap.AutoSize = true;

            this.txtInput.Location = new System.Drawing.Point(140, 68);
            this.txtInput.Size = new System.Drawing.Size(200, 23);

            this.btnInput.Text = "Nhập số";
            this.btnInput.Location = new System.Drawing.Point(360, 65);
            this.btnInput.Size = new System.Drawing.Size(100, 28);
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);

            // ===== ListBox =====
            this.lsbDaySo.Location = new System.Drawing.Point(20, 110);
            this.lsbDaySo.Size = new System.Drawing.Size(250, 200);

            // ===== Group chức năng =====
            this.grpChucNang.Text = "Chức năng:";
            this.grpChucNang.Location = new System.Drawing.Point(290, 110);
            this.grpChucNang.Size = new System.Drawing.Size(280, 200);

            int top = 30, step = 28;

            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.Location = new System.Drawing.Point(20, top);
            this.btnTang2.Size = new System.Drawing.Size(240, 25);
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);

            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.Location = new System.Drawing.Point(20, top + step);
            this.btnChanDau.Size = new System.Drawing.Size(240, 25);
            this.btnChanDau.Click += new System.EventHandler(this.btnChanDau_Click);

            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.Location = new System.Drawing.Point(20, top + step * 2);
            this.btnLeCuoi.Size = new System.Drawing.Size(240, 25);
            this.btnLeCuoi.Click += new System.EventHandler(this.btnLeCuoi_Click);

            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.Location = new System.Drawing.Point(20, top + step * 3);
            this.btnXoaChon.Size = new System.Drawing.Size(240, 25);
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);

            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.Location = new System.Drawing.Point(20, top + step * 4);
            this.btnXoaDau.Size = new System.Drawing.Size(240, 25);
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);

            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.Location = new System.Drawing.Point(20, top + step * 5);
            this.btnXoaCuoi.Size = new System.Drawing.Size(240, 25);
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);

            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.Location = new System.Drawing.Point(20, top + step * 6);
            this.btnXoaDaySo.Size = new System.Drawing.Size(240, 25);
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);

            this.grpChucNang.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnTang2, this.btnChanDau, this.btnLeCuoi,
                this.btnXoaChon, this.btnXoaDau, this.btnXoaCuoi, this.btnXoaDaySo
            });

            // ===== Close button =====
            this.btnClose.Text = "Kết thúc ứng dụng";
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 330);
            this.btnClose.Size = new System.Drawing.Size(550, 30);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // ===== Add to Form =====
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.ListBox lsbDaySo;

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnXoaDaySo;

        private System.Windows.Forms.Button btnClose;
    }
}
