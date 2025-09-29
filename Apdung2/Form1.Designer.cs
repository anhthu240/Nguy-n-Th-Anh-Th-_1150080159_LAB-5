namespace Apdung2   
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.lblKeyboard = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();

            this.lblLog = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Panel";

            // Password label
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(12, 15);
            this.lblPassword.Text = "Password:";

            // Password textbox
            this.txtPassword.Location = new System.Drawing.Point(110, 13);
            this.txtPassword.Size = new System.Drawing.Size(280, 23);
            this.txtPassword.PasswordChar = '•';

            // Keyboard label
            this.lblKeyboard.AutoSize = true;
            this.lblKeyboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKeyboard.Location = new System.Drawing.Point(12, 55);
            this.lblKeyboard.Text = "Keyboard:";

            // Numeric buttons 1..9 (3x3)
            int left0 = 40, top0 = 85, w = 60, h = 40, gap = 10;
            this.btn1.Location = new System.Drawing.Point(left0 + (w + gap) * 0, top0 + (h + gap) * 0);
            this.btn2.Location = new System.Drawing.Point(left0 + (w + gap) * 1, top0 + (h + gap) * 0);
            this.btn3.Location = new System.Drawing.Point(left0 + (w + gap) * 2, top0 + (h + gap) * 0);
            this.btn4.Location = new System.Drawing.Point(left0 + (w + gap) * 0, top0 + (h + gap) * 1);
            this.btn5.Location = new System.Drawing.Point(left0 + (w + gap) * 1, top0 + (h + gap) * 1);
            this.btn6.Location = new System.Drawing.Point(left0 + (w + gap) * 2, top0 + (h + gap) * 1);
            this.btn7.Location = new System.Drawing.Point(left0 + (w + gap) * 0, top0 + (h + gap) * 2);
            this.btn8.Location = new System.Drawing.Point(left0 + (w + gap) * 1, top0 + (h + gap) * 2);
            this.btn9.Location = new System.Drawing.Point(left0 + (w + gap) * 2, top0 + (h + gap) * 2);

            var nums = new[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i].Size = new System.Drawing.Size(w, h);
                nums[i].Text = (i + 1).ToString();
                nums[i].UseVisualStyleBackColor = true;
                nums[i].Click += new System.EventHandler(this.btnNum_Click);
            }

            // Control buttons: Clear / Enter / RING
            this.btnClear.Location = new System.Drawing.Point(340, top0);
            this.btnClear.Size = new System.Drawing.Size(100, h);
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Khaki;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnEnter.Location = new System.Drawing.Point(340, top0 + (h + gap) * 1);
            this.btnEnter.Size = new System.Drawing.Size(100, h);
            this.btnEnter.Text = "Enter";
            this.btnEnter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            this.btnRing.Location = new System.Drawing.Point(340, top0 + (h + gap) * 2);
            this.btnRing.Size = new System.Drawing.Size(100, h);
            this.btnRing.Text = "RING";
            this.btnRing.BackColor = System.Drawing.Color.LightCoral;
            this.btnRing.UseVisualStyleBackColor = true;
            this.btnRing.Click += new System.EventHandler(this.btnRing_Click);

            // Log label
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLog.Location = new System.Drawing.Point(12, 240);
            this.lblLog.Text = "Login Log:";

            // DataGridView
            this.dgvLog.Location = new System.Drawing.Point(12, 265);
            this.dgvLog.Size = new System.Drawing.Size(616, 140);
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTime, this.colGroup, this.colResult
            });

            this.colTime.HeaderText = "Ngày giờ";
            this.colGroup.HeaderText = "Nhóm";
            this.colResult.HeaderText = "Kết quả";

            // Add controls
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.lblKeyboard);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);

            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRing);

            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.dgvLog);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblKeyboard;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
    }
}
