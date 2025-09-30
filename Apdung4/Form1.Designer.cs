namespace Apdung4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.lstDaChon = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightAll = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 7 - Sử dụng Form, ListBox và Button";
            // 
            // Labels
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(20, 18);
            this.lblLeft.Text = "Danh sách các mặt hàng";
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(390, 18);
            this.lblRight.Text = "Các mặt hàng lựa chọn";
            // 
            // lstMatHang
            // 
            this.lstMatHang.Location = new System.Drawing.Point(20, 40);
            this.lstMatHang.Size = new System.Drawing.Size(260, 274);
            this.lstMatHang.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // lstDaChon
            // 
            this.lstDaChon.Location = new System.Drawing.Point(360, 40);
            this.lstDaChon.Size = new System.Drawing.Size(260, 274);
            this.lstDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // Buttons (giữa hai list)
            // 
            int xBtn = 300, y0 = 90, step = 45, w = 40, h = 32;

            this.btnRight.Location = new System.Drawing.Point(xBtn, y0);
            this.btnRight.Size = new System.Drawing.Size(w, h);
            this.btnRight.Text = ">";

            this.btnRightAll.Location = new System.Drawing.Point(xBtn, y0 + step);
            this.btnRightAll.Size = new System.Drawing.Size(w, h);
            this.btnRightAll.Text = ">>";

            this.btnLeft.Location = new System.Drawing.Point(xBtn, y0 + step * 2);
            this.btnLeft.Size = new System.Drawing.Size(w, h);
            this.btnLeft.Text = "<";

            this.btnLeftAll.Location = new System.Drawing.Point(xBtn, y0 + step * 3);
            this.btnLeftAll.Size = new System.Drawing.Size(w, h);
            this.btnLeftAll.Text = "<<";

            // 
            // Add controls
            // 
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lstMatHang);
            this.Controls.Add(this.lstDaChon);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnRightAll);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLeftAll);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.ListBox lstDaChon;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightAll;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftAll;
    }
}
