namespace QLSACH
{
    partial class F_Login
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
            tbUserName_Login = new TextBox();
            tbPassWord_Login = new TextBox();
            btnDangNhap_Login = new Button();
            btnThoat_Login = new Button();
            cbReveal_pass = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(125, 44);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(125, 83);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // tbUserName_Login
            // 
            tbUserName_Login.BorderStyle = BorderStyle.FixedSingle;
            tbUserName_Login.Font = new Font("Segoe UI", 12F);
            tbUserName_Login.Location = new Point(242, 42);
            tbUserName_Login.Name = "tbUserName_Login";
            tbUserName_Login.Size = new Size(213, 29);
            tbUserName_Login.TabIndex = 2;
            // 
            // tbPassWord_Login
            // 
            tbPassWord_Login.BorderStyle = BorderStyle.FixedSingle;
            tbPassWord_Login.Font = new Font("Segoe UI", 12F);
            tbPassWord_Login.Location = new Point(242, 81);
            tbPassWord_Login.Name = "tbPassWord_Login";
            tbPassWord_Login.Size = new Size(213, 29);
            tbPassWord_Login.TabIndex = 3;
            // 
            // btnDangNhap_Login
            // 
            btnDangNhap_Login.Font = new Font("Segoe UI", 12F);
            btnDangNhap_Login.Location = new Point(125, 162);
            btnDangNhap_Login.Name = "btnDangNhap_Login";
            btnDangNhap_Login.Size = new Size(111, 40);
            btnDangNhap_Login.TabIndex = 4;
            btnDangNhap_Login.Text = "Đăng nhập";
            btnDangNhap_Login.UseVisualStyleBackColor = true;
            btnDangNhap_Login.Click += btnDangNhap_Login_Click;
            // 
            // btnThoat_Login
            // 
            btnThoat_Login.Font = new Font("Segoe UI", 12F);
            btnThoat_Login.Location = new Point(344, 162);
            btnThoat_Login.Name = "btnThoat_Login";
            btnThoat_Login.Size = new Size(111, 40);
            btnThoat_Login.TabIndex = 5;
            btnThoat_Login.Text = "Thoát";
            btnThoat_Login.UseVisualStyleBackColor = true;
            btnThoat_Login.Click += btnThoat_Login_Click;
            // 
            // cbReveal_pass
            // 
            cbReveal_pass.AutoSize = true;
            cbReveal_pass.Font = new Font("Segoe UI", 12F);
            cbReveal_pass.Location = new Point(325, 116);
            cbReveal_pass.Name = "cbReveal_pass";
            cbReveal_pass.Size = new Size(130, 25);
            cbReveal_pass.TabIndex = 6;
            cbReveal_pass.Text = "Hiện mật khẩu";
            cbReveal_pass.UseVisualStyleBackColor = true;
            cbReveal_pass.CheckedChanged += cbReveal_pass_CheckedChanged;
            // 
            // F_Login
            // 
            AcceptButton = btnDangNhap_Login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat_Login;
            ClientSize = new Size(581, 245);
            Controls.Add(cbReveal_pass);
            Controls.Add(btnThoat_Login);
            Controls.Add(btnDangNhap_Login);
            Controls.Add(tbPassWord_Login);
            Controls.Add(tbUserName_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "F_Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += F_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUserName_Login;
        private TextBox tbPassWord_Login;
        private Button btnDangNhap_Login;
        private Button btnThoat_Login;
        private CheckBox cbReveal_pass;
    }
}
