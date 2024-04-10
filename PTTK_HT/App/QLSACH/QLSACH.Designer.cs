namespace QLSACH
{
    partial class QLSACH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcMain = new TabControl();
            tbCapNhat = new TabPage();
            tcCapNhat = new TabControl();
            tpCapNhatSach = new TabPage();
            btnResetSach_CN = new Button();
            btnSuaSach_CN = new Button();
            btnXoaSach_CN = new Button();
            btnThemSach_CN = new Button();
            dgSach_CN = new DataGridView();
            dtpNgayCN = new DateTimePicker();
            tbGia_CN = new TextBox();
            tbNXB_CN = new TextBox();
            tbTacGia_CN = new TextBox();
            tbTenSach_CN = new TextBox();
            tbMaSach_CN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tpCapNhatKH = new TabPage();
            btnResetKH_CN = new Button();
            btnSuaKH_CN = new Button();
            btnXoaKH_CN = new Button();
            btnThemKH_CN = new Button();
            dgKH_CN = new DataGridView();
            dtpNgaySinh_KH_CN = new DateTimePicker();
            tbSDT_KH_CN = new TextBox();
            tbDiaChiKH_CN = new TextBox();
            tbHoTenKH_CN = new TextBox();
            lable13 = new Label();
            lable12 = new Label();
            label11 = new Label();
            label12 = new Label();
            tpCapNhatNV = new TabPage();
            btnResetNV_CN = new Button();
            btnSuaNV_CN = new Button();
            btnXoaNV_CN = new Button();
            btnThemNV_CN = new Button();
            dgNV_CN = new DataGridView();
            tbPassword_CN = new TextBox();
            tbUsername_CN = new TextBox();
            tbMaNV_CN = new TextBox();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            tabPage2 = new TabPage();
            tbTimKiem = new TabPage();
            tbThongKe = new TabPage();
            tcMain.SuspendLayout();
            tbCapNhat.SuspendLayout();
            tcCapNhat.SuspendLayout();
            tpCapNhatSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgSach_CN).BeginInit();
            tpCapNhatKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgKH_CN).BeginInit();
            tpCapNhatNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNV_CN).BeginInit();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tbCapNhat);
            tcMain.Controls.Add(tbTimKiem);
            tcMain.Controls.Add(tbThongKe);
            tcMain.Dock = DockStyle.Fill;
            tcMain.Location = new Point(0, 0);
            tcMain.Margin = new Padding(4);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(984, 661);
            tcMain.TabIndex = 0;
            // 
            // tbCapNhat
            // 
            tbCapNhat.Controls.Add(tcCapNhat);
            tbCapNhat.Location = new Point(4, 30);
            tbCapNhat.Margin = new Padding(4);
            tbCapNhat.Name = "tbCapNhat";
            tbCapNhat.Padding = new Padding(4);
            tbCapNhat.Size = new Size(976, 627);
            tbCapNhat.TabIndex = 0;
            tbCapNhat.Text = "Cập nhật";
            tbCapNhat.UseVisualStyleBackColor = true;
            // 
            // tcCapNhat
            // 
            tcCapNhat.Controls.Add(tpCapNhatSach);
            tcCapNhat.Controls.Add(tpCapNhatKH);
            tcCapNhat.Controls.Add(tpCapNhatNV);
            tcCapNhat.Controls.Add(tabPage2);
            tcCapNhat.Dock = DockStyle.Fill;
            tcCapNhat.Location = new Point(4, 4);
            tcCapNhat.Name = "tcCapNhat";
            tcCapNhat.SelectedIndex = 0;
            tcCapNhat.Size = new Size(968, 619);
            tcCapNhat.TabIndex = 0;
            tcCapNhat.SelectedIndexChanged += tcCapNhat_SelectedIndexChanged;
            // 
            // tpCapNhatSach
            // 
            tpCapNhatSach.Controls.Add(btnResetSach_CN);
            tpCapNhatSach.Controls.Add(btnSuaSach_CN);
            tpCapNhatSach.Controls.Add(btnXoaSach_CN);
            tpCapNhatSach.Controls.Add(btnThemSach_CN);
            tpCapNhatSach.Controls.Add(dgSach_CN);
            tpCapNhatSach.Controls.Add(dtpNgayCN);
            tpCapNhatSach.Controls.Add(tbGia_CN);
            tpCapNhatSach.Controls.Add(tbNXB_CN);
            tpCapNhatSach.Controls.Add(tbTacGia_CN);
            tpCapNhatSach.Controls.Add(tbTenSach_CN);
            tpCapNhatSach.Controls.Add(tbMaSach_CN);
            tpCapNhatSach.Controls.Add(label6);
            tpCapNhatSach.Controls.Add(label5);
            tpCapNhatSach.Controls.Add(label4);
            tpCapNhatSach.Controls.Add(label3);
            tpCapNhatSach.Controls.Add(label2);
            tpCapNhatSach.Controls.Add(label1);
            tpCapNhatSach.Location = new Point(4, 30);
            tpCapNhatSach.Name = "tpCapNhatSach";
            tpCapNhatSach.Padding = new Padding(3);
            tpCapNhatSach.Size = new Size(960, 585);
            tpCapNhatSach.TabIndex = 0;
            tpCapNhatSach.Text = "Cập nhật sách";
            tpCapNhatSach.UseVisualStyleBackColor = true;
            // 
            // btnResetSach_CN
            // 
            btnResetSach_CN.Anchor = AnchorStyles.Bottom;
            btnResetSach_CN.Location = new Point(628, 543);
            btnResetSach_CN.Name = "btnResetSach_CN";
            btnResetSach_CN.Size = new Size(110, 39);
            btnResetSach_CN.TabIndex = 67;
            btnResetSach_CN.Text = "Reset";
            btnResetSach_CN.UseVisualStyleBackColor = true;
            btnResetSach_CN.Click += btnResetSach_CN_Click;
            // 
            // btnSuaSach_CN
            // 
            btnSuaSach_CN.Anchor = AnchorStyles.Bottom;
            btnSuaSach_CN.Location = new Point(494, 543);
            btnSuaSach_CN.Name = "btnSuaSach_CN";
            btnSuaSach_CN.Size = new Size(110, 39);
            btnSuaSach_CN.TabIndex = 66;
            btnSuaSach_CN.Text = "Sửa";
            btnSuaSach_CN.UseVisualStyleBackColor = true;
            btnSuaSach_CN.Click += btnSuaSach_CN_Click;
            // 
            // btnXoaSach_CN
            // 
            btnXoaSach_CN.Anchor = AnchorStyles.Bottom;
            btnXoaSach_CN.Location = new Point(362, 543);
            btnXoaSach_CN.Name = "btnXoaSach_CN";
            btnXoaSach_CN.Size = new Size(110, 39);
            btnXoaSach_CN.TabIndex = 65;
            btnXoaSach_CN.Text = "Xóa";
            btnXoaSach_CN.UseVisualStyleBackColor = true;
            btnXoaSach_CN.Click += btnXoaSach_CN_Click;
            // 
            // btnThemSach_CN
            // 
            btnThemSach_CN.Anchor = AnchorStyles.Bottom;
            btnThemSach_CN.Location = new Point(237, 543);
            btnThemSach_CN.Name = "btnThemSach_CN";
            btnThemSach_CN.Size = new Size(110, 39);
            btnThemSach_CN.TabIndex = 64;
            btnThemSach_CN.Text = "Thêm";
            btnThemSach_CN.UseVisualStyleBackColor = true;
            btnThemSach_CN.Click += btnThemSach_CN_Click;
            // 
            // dgSach_CN
            // 
            dgSach_CN.AllowUserToAddRows = false;
            dgSach_CN.AllowUserToDeleteRows = false;
            dgSach_CN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgSach_CN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSach_CN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSach_CN.Location = new Point(6, 137);
            dgSach_CN.MultiSelect = false;
            dgSach_CN.Name = "dgSach_CN";
            dgSach_CN.ReadOnly = true;
            dgSach_CN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSach_CN.Size = new Size(954, 404);
            dgSach_CN.TabIndex = 29;
            dgSach_CN.CellContentClick += dgSach_CN_CellContentClick;
            // 
            // dtpNgayCN
            // 
            dtpNgayCN.Anchor = AnchorStyles.Top;
            dtpNgayCN.CustomFormat = "";
            dtpNgayCN.Enabled = false;
            dtpNgayCN.Format = DateTimePickerFormat.Short;
            dtpNgayCN.Location = new Point(592, 98);
            dtpNgayCN.Name = "dtpNgayCN";
            dtpNgayCN.Size = new Size(220, 29);
            dtpNgayCN.TabIndex = 28;
            // 
            // tbGia_CN
            // 
            tbGia_CN.Anchor = AnchorStyles.Top;
            tbGia_CN.BorderStyle = BorderStyle.FixedSingle;
            tbGia_CN.Location = new Point(592, 57);
            tbGia_CN.Name = "tbGia_CN";
            tbGia_CN.Size = new Size(220, 29);
            tbGia_CN.TabIndex = 27;
            // 
            // tbNXB_CN
            // 
            tbNXB_CN.Anchor = AnchorStyles.Top;
            tbNXB_CN.BorderStyle = BorderStyle.FixedSingle;
            tbNXB_CN.Location = new Point(592, 12);
            tbNXB_CN.Name = "tbNXB_CN";
            tbNXB_CN.Size = new Size(220, 29);
            tbNXB_CN.TabIndex = 26;
            // 
            // tbTacGia_CN
            // 
            tbTacGia_CN.Anchor = AnchorStyles.Top;
            tbTacGia_CN.BorderStyle = BorderStyle.FixedSingle;
            tbTacGia_CN.Location = new Point(216, 102);
            tbTacGia_CN.Name = "tbTacGia_CN";
            tbTacGia_CN.Size = new Size(220, 29);
            tbTacGia_CN.TabIndex = 25;
            // 
            // tbTenSach_CN
            // 
            tbTenSach_CN.Anchor = AnchorStyles.Top;
            tbTenSach_CN.BorderStyle = BorderStyle.FixedSingle;
            tbTenSach_CN.Location = new Point(216, 57);
            tbTenSach_CN.Name = "tbTenSach_CN";
            tbTenSach_CN.Size = new Size(220, 29);
            tbTenSach_CN.TabIndex = 24;
            // 
            // tbMaSach_CN
            // 
            tbMaSach_CN.Anchor = AnchorStyles.Top;
            tbMaSach_CN.BorderStyle = BorderStyle.FixedSingle;
            tbMaSach_CN.Location = new Point(216, 12);
            tbMaSach_CN.Name = "tbMaSach_CN";
            tbMaSach_CN.Size = new Size(220, 29);
            tbMaSach_CN.TabIndex = 23;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(477, 104);
            label6.Name = "label6";
            label6.Size = new Size(113, 21);
            label6.TabIndex = 22;
            label6.Text = "Ngày cập nhật:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(477, 59);
            label5.Name = "label5";
            label5.Size = new Size(36, 21);
            label5.TabIndex = 21;
            label5.Text = "Giá:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(477, 14);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 20;
            label4.Text = "NXB:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(140, 104);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 19;
            label3.Text = "Tác giả:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(140, 59);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 18;
            label2.Text = "Tên sách:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(140, 14);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 17;
            label1.Text = "Mã sách:";
            // 
            // tpCapNhatKH
            // 
            tpCapNhatKH.Controls.Add(btnResetKH_CN);
            tpCapNhatKH.Controls.Add(btnSuaKH_CN);
            tpCapNhatKH.Controls.Add(btnXoaKH_CN);
            tpCapNhatKH.Controls.Add(btnThemKH_CN);
            tpCapNhatKH.Controls.Add(dgKH_CN);
            tpCapNhatKH.Controls.Add(dtpNgaySinh_KH_CN);
            tpCapNhatKH.Controls.Add(tbSDT_KH_CN);
            tpCapNhatKH.Controls.Add(tbDiaChiKH_CN);
            tpCapNhatKH.Controls.Add(tbHoTenKH_CN);
            tpCapNhatKH.Controls.Add(lable13);
            tpCapNhatKH.Controls.Add(lable12);
            tpCapNhatKH.Controls.Add(label11);
            tpCapNhatKH.Controls.Add(label12);
            tpCapNhatKH.Location = new Point(4, 24);
            tpCapNhatKH.Name = "tpCapNhatKH";
            tpCapNhatKH.Padding = new Padding(3);
            tpCapNhatKH.Size = new Size(960, 591);
            tpCapNhatKH.TabIndex = 1;
            tpCapNhatKH.Text = "Cập nhật khách hàng";
            tpCapNhatKH.UseVisualStyleBackColor = true;
            // 
            // btnResetKH_CN
            // 
            btnResetKH_CN.Anchor = AnchorStyles.Bottom;
            btnResetKH_CN.Location = new Point(621, 543);
            btnResetKH_CN.Name = "btnResetKH_CN";
            btnResetKH_CN.Size = new Size(110, 39);
            btnResetKH_CN.TabIndex = 50;
            btnResetKH_CN.Text = "Reset";
            btnResetKH_CN.UseVisualStyleBackColor = true;
            btnResetKH_CN.Click += btnResetKH_CN_Click;
            // 
            // btnSuaKH_CN
            // 
            btnSuaKH_CN.Anchor = AnchorStyles.Bottom;
            btnSuaKH_CN.Location = new Point(487, 543);
            btnSuaKH_CN.Name = "btnSuaKH_CN";
            btnSuaKH_CN.Size = new Size(110, 39);
            btnSuaKH_CN.TabIndex = 49;
            btnSuaKH_CN.Text = "Sửa";
            btnSuaKH_CN.UseVisualStyleBackColor = true;
            btnSuaKH_CN.Click += btnSuaKH_CN_Click;
            // 
            // btnXoaKH_CN
            // 
            btnXoaKH_CN.Anchor = AnchorStyles.Bottom;
            btnXoaKH_CN.Location = new Point(355, 543);
            btnXoaKH_CN.Name = "btnXoaKH_CN";
            btnXoaKH_CN.Size = new Size(110, 39);
            btnXoaKH_CN.TabIndex = 48;
            btnXoaKH_CN.Text = "Xóa";
            btnXoaKH_CN.UseVisualStyleBackColor = true;
            btnXoaKH_CN.Click += btnXoaKH_CN_Click;
            // 
            // btnThemKH_CN
            // 
            btnThemKH_CN.Anchor = AnchorStyles.Bottom;
            btnThemKH_CN.Location = new Point(230, 543);
            btnThemKH_CN.Name = "btnThemKH_CN";
            btnThemKH_CN.Size = new Size(110, 39);
            btnThemKH_CN.TabIndex = 47;
            btnThemKH_CN.Text = "Thêm";
            btnThemKH_CN.UseVisualStyleBackColor = true;
            btnThemKH_CN.Click += btnThemKH_CN_Click;
            // 
            // dgKH_CN
            // 
            dgKH_CN.AllowUserToAddRows = false;
            dgKH_CN.AllowUserToDeleteRows = false;
            dgKH_CN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgKH_CN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgKH_CN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgKH_CN.Location = new Point(3, 151);
            dgKH_CN.MultiSelect = false;
            dgKH_CN.Name = "dgKH_CN";
            dgKH_CN.ReadOnly = true;
            dgKH_CN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgKH_CN.Size = new Size(954, 386);
            dgKH_CN.TabIndex = 46;
            dgKH_CN.CellContentClick += dgKH_CN_CellContentClick;
            // 
            // dtpNgaySinh_KH_CN
            // 
            dtpNgaySinh_KH_CN.Anchor = AnchorStyles.Top;
            dtpNgaySinh_KH_CN.CustomFormat = "";
            dtpNgaySinh_KH_CN.Format = DateTimePickerFormat.Short;
            dtpNgaySinh_KH_CN.Location = new Point(594, 81);
            dtpNgaySinh_KH_CN.Name = "dtpNgaySinh_KH_CN";
            dtpNgaySinh_KH_CN.Size = new Size(220, 29);
            dtpNgaySinh_KH_CN.TabIndex = 45;
            // 
            // tbSDT_KH_CN
            // 
            tbSDT_KH_CN.Anchor = AnchorStyles.Top;
            tbSDT_KH_CN.BorderStyle = BorderStyle.FixedSingle;
            tbSDT_KH_CN.Location = new Point(594, 40);
            tbSDT_KH_CN.Name = "tbSDT_KH_CN";
            tbSDT_KH_CN.Size = new Size(220, 29);
            tbSDT_KH_CN.TabIndex = 44;
            // 
            // tbDiaChiKH_CN
            // 
            tbDiaChiKH_CN.Anchor = AnchorStyles.Top;
            tbDiaChiKH_CN.BorderStyle = BorderStyle.FixedSingle;
            tbDiaChiKH_CN.Location = new Point(216, 85);
            tbDiaChiKH_CN.Name = "tbDiaChiKH_CN";
            tbDiaChiKH_CN.Size = new Size(220, 29);
            tbDiaChiKH_CN.TabIndex = 41;
            // 
            // tbHoTenKH_CN
            // 
            tbHoTenKH_CN.Anchor = AnchorStyles.Top;
            tbHoTenKH_CN.BorderStyle = BorderStyle.FixedSingle;
            tbHoTenKH_CN.Location = new Point(216, 40);
            tbHoTenKH_CN.Name = "tbHoTenKH_CN";
            tbHoTenKH_CN.Size = new Size(220, 29);
            tbHoTenKH_CN.TabIndex = 40;
            // 
            // lable13
            // 
            lable13.Anchor = AnchorStyles.Top;
            lable13.AutoSize = true;
            lable13.Location = new Point(479, 87);
            lable13.Name = "lable13";
            lable13.Size = new Size(83, 21);
            lable13.TabIndex = 39;
            lable13.Text = "Ngày sinh:";
            // 
            // lable12
            // 
            lable12.Anchor = AnchorStyles.Top;
            lable12.AutoSize = true;
            lable12.Location = new Point(479, 42);
            lable12.Name = "lable12";
            lable12.Size = new Size(104, 21);
            lable12.TabIndex = 36;
            lable12.Text = "Số điện thoại:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(140, 87);
            label11.Name = "label11";
            label11.Size = new Size(60, 21);
            label11.TabIndex = 35;
            label11.Text = "Địa chỉ:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Location = new Point(140, 42);
            label12.Name = "label12";
            label12.Size = new Size(59, 21);
            label12.TabIndex = 34;
            label12.Text = "Họ tên:";
            // 
            // tpCapNhatNV
            // 
            tpCapNhatNV.Controls.Add(btnResetNV_CN);
            tpCapNhatNV.Controls.Add(btnSuaNV_CN);
            tpCapNhatNV.Controls.Add(btnXoaNV_CN);
            tpCapNhatNV.Controls.Add(btnThemNV_CN);
            tpCapNhatNV.Controls.Add(dgNV_CN);
            tpCapNhatNV.Controls.Add(tbPassword_CN);
            tpCapNhatNV.Controls.Add(tbUsername_CN);
            tpCapNhatNV.Controls.Add(tbMaNV_CN);
            tpCapNhatNV.Controls.Add(label10);
            tpCapNhatNV.Controls.Add(label13);
            tpCapNhatNV.Controls.Add(label14);
            tpCapNhatNV.Location = new Point(4, 24);
            tpCapNhatNV.Name = "tpCapNhatNV";
            tpCapNhatNV.Size = new Size(960, 591);
            tpCapNhatNV.TabIndex = 2;
            tpCapNhatNV.Text = "Cập nhật nhân viên";
            tpCapNhatNV.UseVisualStyleBackColor = true;
            // 
            // btnResetNV_CN
            // 
            btnResetNV_CN.Anchor = AnchorStyles.Bottom;
            btnResetNV_CN.Location = new Point(621, 527);
            btnResetNV_CN.Name = "btnResetNV_CN";
            btnResetNV_CN.Size = new Size(110, 39);
            btnResetNV_CN.TabIndex = 63;
            btnResetNV_CN.Text = "Reset";
            btnResetNV_CN.UseVisualStyleBackColor = true;
            btnResetNV_CN.Click += btnResetNV_CN_Click;
            // 
            // btnSuaNV_CN
            // 
            btnSuaNV_CN.Anchor = AnchorStyles.Bottom;
            btnSuaNV_CN.Location = new Point(487, 527);
            btnSuaNV_CN.Name = "btnSuaNV_CN";
            btnSuaNV_CN.Size = new Size(110, 39);
            btnSuaNV_CN.TabIndex = 62;
            btnSuaNV_CN.Text = "Sửa";
            btnSuaNV_CN.UseVisualStyleBackColor = true;
            btnSuaNV_CN.Click += btnSuaNV_CN_Click;
            // 
            // btnXoaNV_CN
            // 
            btnXoaNV_CN.Anchor = AnchorStyles.Bottom;
            btnXoaNV_CN.Location = new Point(355, 527);
            btnXoaNV_CN.Name = "btnXoaNV_CN";
            btnXoaNV_CN.Size = new Size(110, 39);
            btnXoaNV_CN.TabIndex = 61;
            btnXoaNV_CN.Text = "Xóa";
            btnXoaNV_CN.UseVisualStyleBackColor = true;
            btnXoaNV_CN.Click += btnXoaNV_CN_Click;
            // 
            // btnThemNV_CN
            // 
            btnThemNV_CN.Anchor = AnchorStyles.Bottom;
            btnThemNV_CN.Location = new Point(230, 527);
            btnThemNV_CN.Name = "btnThemNV_CN";
            btnThemNV_CN.Size = new Size(110, 39);
            btnThemNV_CN.TabIndex = 60;
            btnThemNV_CN.Text = "Thêm";
            btnThemNV_CN.UseVisualStyleBackColor = true;
            btnThemNV_CN.Click += btnThemNV_CN_Click;
            // 
            // dgNV_CN
            // 
            dgNV_CN.AllowUserToAddRows = false;
            dgNV_CN.AllowUserToDeleteRows = false;
            dgNV_CN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgNV_CN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgNV_CN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNV_CN.Location = new Point(3, 135);
            dgNV_CN.MultiSelect = false;
            dgNV_CN.Name = "dgNV_CN";
            dgNV_CN.ReadOnly = true;
            dgNV_CN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgNV_CN.Size = new Size(954, 386);
            dgNV_CN.TabIndex = 59;
            dgNV_CN.CellContentClick += dgNV_CN_CellContentClick;
            // 
            // tbPassword_CN
            // 
            tbPassword_CN.Anchor = AnchorStyles.Top;
            tbPassword_CN.BorderStyle = BorderStyle.FixedSingle;
            tbPassword_CN.Location = new Point(597, 30);
            tbPassword_CN.Name = "tbPassword_CN";
            tbPassword_CN.Size = new Size(220, 29);
            tbPassword_CN.TabIndex = 57;
            // 
            // tbUsername_CN
            // 
            tbUsername_CN.Anchor = AnchorStyles.Top;
            tbUsername_CN.BorderStyle = BorderStyle.FixedSingle;
            tbUsername_CN.Location = new Point(219, 84);
            tbUsername_CN.Name = "tbUsername_CN";
            tbUsername_CN.Size = new Size(220, 29);
            tbUsername_CN.TabIndex = 56;
            // 
            // tbMaNV_CN
            // 
            tbMaNV_CN.Anchor = AnchorStyles.Top;
            tbMaNV_CN.BorderStyle = BorderStyle.FixedSingle;
            tbMaNV_CN.Location = new Point(219, 30);
            tbMaNV_CN.Name = "tbMaNV_CN";
            tbMaNV_CN.Size = new Size(220, 29);
            tbMaNV_CN.TabIndex = 55;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(501, 32);
            label10.Name = "label10";
            label10.Size = new Size(79, 21);
            label10.TabIndex = 53;
            label10.Text = "Password:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Location = new Point(106, 86);
            label13.Name = "label13";
            label13.Size = new Size(84, 21);
            label13.TabIndex = 52;
            label13.Text = "Username:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Location = new Point(106, 32);
            label14.Name = "label14";
            label14.Size = new Size(107, 21);
            label14.TabIndex = 51;
            label14.Text = "Mã nhân viên:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(960, 591);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Location = new Point(4, 24);
            tbTimKiem.Margin = new Padding(4);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Padding = new Padding(4);
            tbTimKiem.Size = new Size(976, 633);
            tbTimKiem.TabIndex = 1;
            tbTimKiem.Text = "Tìm kiếm";
            tbTimKiem.UseVisualStyleBackColor = true;
            // 
            // tbThongKe
            // 
            tbThongKe.Location = new Point(4, 24);
            tbThongKe.Name = "tbThongKe";
            tbThongKe.Size = new Size(976, 633);
            tbThongKe.TabIndex = 2;
            tbThongKe.Text = "Thống kê";
            tbThongKe.UseVisualStyleBackColor = true;
            // 
            // QLSACH
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(tcMain);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "QLSACH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLSACH";
            Load += QLSACH_Load;
            tcMain.ResumeLayout(false);
            tbCapNhat.ResumeLayout(false);
            tcCapNhat.ResumeLayout(false);
            tpCapNhatSach.ResumeLayout(false);
            tpCapNhatSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgSach_CN).EndInit();
            tpCapNhatKH.ResumeLayout(false);
            tpCapNhatKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgKH_CN).EndInit();
            tpCapNhatNV.ResumeLayout(false);
            tpCapNhatNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgNV_CN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMain;
        private TabPage tbCapNhat;
        private TabPage tbTimKiem;
        private TabPage tbThongKe;
        private TabControl tcCapNhat;
        private TabPage tpCapNhatSach;
        private TabPage tpCapNhatKH;
        private TabPage tpCapNhatNV;
        private TabPage tabPage2;
        private DataGridView dgSach_CN;
        private DateTimePicker dtpNgayCN;
        private TextBox tbGia_CN;
        private TextBox tbNXB_CN;
        private TextBox tbTacGia_CN;
        private TextBox tbTenSach_CN;
        private TextBox tbMaSach_CN;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnResetKH_CN;
        private Button btnSuaKH_CN;
        private Button btnXoaKH_CN;
        private Button btnThemKH_CN;
        private DataGridView dgKH_CN;
        private DateTimePicker dtpNgaySinh_KH_CN;
        private TextBox tbSDT_KH_CN;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox tbDiaChiKH_CN;
        private TextBox tbHoTenKH_CN;
        private Label lable13;
        private Label label8;
        private Label label9;
        private Label lable12;
        private Label label11;
        private Label label12;
        private Button btnResetNV_CN;
        private Button btnSuaNV_CN;
        private Button btnXoaNV_CN;
        private Button btnThemNV_CN;
        private DataGridView dgNV_CN;
        private TextBox tbPassword_CN;
        private TextBox tbUsername_CN;
        private TextBox tbMaNV_CN;
        private Label label10;
        private Label label13;
        private Label label14;
        private Button btnResetSach_CN;
        private Button btnSuaSach_CN;
        private Button btnXoaSach_CN;
        private Button btnThemSach_CN;
    }
}