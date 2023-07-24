namespace TinhTong2SoGUI
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoThuNhat = new TextBox();
            txtSoThuHai = new TextBox();
            txtKetQua = new TextBox();
            btnTong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 21);
            label1.TabIndex = 0;
            label1.Text = "Chương Trình Tính Tổng";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 55);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 1;
            label2.Text = "Nhập số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 92);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "Nhập số thứ hai";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 128);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // txtSoThuNhat
            // 
            txtSoThuNhat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoThuNhat.Location = new Point(183, 55);
            txtSoThuNhat.Name = "txtSoThuNhat";
            txtSoThuNhat.Size = new Size(168, 29);
            txtSoThuNhat.TabIndex = 4;
            // 
            // txtSoThuHai
            // 
            txtSoThuHai.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoThuHai.Location = new Point(183, 90);
            txtSoThuHai.Name = "txtSoThuHai";
            txtSoThuHai.Size = new Size(168, 29);
            txtSoThuHai.TabIndex = 4;
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtKetQua.Location = new Point(183, 125);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(168, 29);
            txtKetQua.TabIndex = 4;
            // 
            // btnTong
            // 
            btnTong.BackColor = Color.DarkOrange;
            btnTong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTong.ForeColor = SystemColors.ButtonHighlight;
            btnTong.Location = new Point(183, 181);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(168, 40);
            btnTong.TabIndex = 5;
            btnTong.Text = "Tính tổng";
            btnTong.UseVisualStyleBackColor = false;
            btnTong.Click += btnTong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 248);
            Controls.Add(btnTong);
            Controls.Add(txtKetQua);
            Controls.Add(txtSoThuHai);
            Controls.Add(txtSoThuNhat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tính Tổng";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoThuNhat;
        private TextBox txtSoThuHai;
        private TextBox txtKetQua;
        private Button btnTong;
    }
}