namespace Apdung1   // <-- TRÙNG y hệt với Form1.cs
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
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.groupOption = new System.Windows.Forms.GroupBox();
            this.rdoUSCLN = new System.Windows.Forms.RadioButton();
            this.rdoBSCNN = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupInput.SuspendLayout();
            this.groupOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 260);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm USCLN và BSCNN của a, b";

            // groupInput
            this.groupInput.Text = "Nhập dữ liệu:";
            this.groupInput.BackColor = System.Drawing.Color.Honeydew;
            this.groupInput.Location = new System.Drawing.Point(12, 12);
            this.groupInput.Size = new System.Drawing.Size(360, 120);

            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(16, 34);
            this.lblA.Text = "Số nguyên a:";
            this.txtA.Location = new System.Drawing.Point(120, 31);
            this.txtA.Size = new System.Drawing.Size(210, 23);

            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(16, 70);
            this.lblB.Text = "Số nguyên b:";
            this.txtB.Location = new System.Drawing.Point(120, 67);
            this.txtB.Size = new System.Drawing.Size(210, 23);

            this.groupInput.Controls.Add(this.lblA);
            this.groupInput.Controls.Add(this.txtA);
            this.groupInput.Controls.Add(this.lblB);
            this.groupInput.Controls.Add(this.txtB);

            // groupOption
            this.groupOption.Text = "Tùy chọn:";
            this.groupOption.Location = new System.Drawing.Point(390, 12);
            this.groupOption.Size = new System.Drawing.Size(190, 120);

            this.rdoUSCLN.AutoSize = true;
            this.rdoUSCLN.Location = new System.Drawing.Point(20, 35);
            this.rdoUSCLN.Text = "USCLN";

            this.rdoBSCNN.AutoSize = true;
            this.rdoBSCNN.Location = new System.Drawing.Point(20, 70);
            this.rdoBSCNN.Text = "BSCNN";

            this.groupOption.Controls.Add(this.rdoUSCLN);
            this.groupOption.Controls.Add(this.rdoBSCNN);

            // kết quả + nút
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(24, 154);
            this.lblKetQua.Text = "Kết quả:";

            this.txtKetQua.Location = new System.Drawing.Point(90, 151);
            this.txtKetQua.Size = new System.Drawing.Size(282, 23);
            this.txtKetQua.ReadOnly = true;

            this.btnTim.Location = new System.Drawing.Point(390, 148);
            this.btnTim.Size = new System.Drawing.Size(90, 30);
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);

            this.btnThoat.Location = new System.Drawing.Point(490, 148);
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // add controls to form
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.groupOption);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThoat);

            this.groupInput.ResumeLayout(false);
            this.groupInput.PerformLayout();
            this.groupOption.ResumeLayout(false);
            this.groupOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        // ===== Fields do Designer khai báo =====
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;

        private System.Windows.Forms.GroupBox groupOption;
        private System.Windows.Forms.RadioButton rdoUSCLN;
        private System.Windows.Forms.RadioButton rdoBSCNN;

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
    }
}
