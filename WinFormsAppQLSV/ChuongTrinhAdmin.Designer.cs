namespace QuanLySinhVien
{
    partial class ChuongTrinhAdmin
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
            panel1 = new Panel();
            lblTieuDe = new Label();
            btnDangXuat = new Button();
            btnMonHoc = new Button();
            btnTaiKhan = new Button();
            groupBox1 = new GroupBox();
            txtMSV = new TextBox();
            cbBoxGenDer4 = new ComboBox();
            txtGender = new TextBox();
            valueLop = new TextBox();
            valueCN = new TextBox();
            btnSua = new Button();
            txt2 = new TextBox();
            txt1 = new TextBox();
            cbBoxLop = new ComboBox();
            cbBoxChuyenNganh = new ComboBox();
            btnXoa = new Button();
            btnLuu = new Button();
            lblchitiet3 = new Label();
            dtpChiTiet3 = new DateTimePicker();
            lblchitiet9 = new Label();
            lblchitiet8 = new Label();
            lblchitiet4 = new Label();
            txtChiTiet2 = new TextBox();
            lblchitiet2 = new Label();
            txtChiTiet1 = new TextBox();
            lblchitiet1 = new Label();
            splitter1 = new Splitter();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            dgvAdmin = new DataGridView();
            panel2 = new Panel();
            btnSinhVien = new Button();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTieuDe);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 67);
            panel1.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTieuDe.Location = new Point(456, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(233, 38);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Quản lý sinh viên";
            lblTieuDe.Click += lblTieuDe_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(534, 33);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(112, 34);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnMonHoc
            // 
            btnMonHoc.Location = new Point(223, 33);
            btnMonHoc.Name = "btnMonHoc";
            btnMonHoc.Size = new Size(112, 34);
            btnMonHoc.TabIndex = 1;
            btnMonHoc.Text = "Môn học";
            btnMonHoc.UseVisualStyleBackColor = true;
            btnMonHoc.Click += btnMonHoc_Click;
            // 
            // btnTaiKhan
            // 
            btnTaiKhan.Location = new Point(382, 33);
            btnTaiKhan.Name = "btnTaiKhan";
            btnTaiKhan.RightToLeft = RightToLeft.No;
            btnTaiKhan.Size = new Size(112, 34);
            btnTaiKhan.TabIndex = 2;
            btnTaiKhan.Text = "Tài Khoản";
            btnTaiKhan.UseVisualStyleBackColor = true;
            btnTaiKhan.Click += btnTaiKhan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMSV);
            groupBox1.Controls.Add(cbBoxGenDer4);
            groupBox1.Controls.Add(txtGender);
            groupBox1.Controls.Add(valueLop);
            groupBox1.Controls.Add(valueCN);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txt2);
            groupBox1.Controls.Add(txt1);
            groupBox1.Controls.Add(cbBoxLop);
            groupBox1.Controls.Add(cbBoxChuyenNganh);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(lblchitiet3);
            groupBox1.Controls.Add(dtpChiTiet3);
            groupBox1.Controls.Add(lblchitiet9);
            groupBox1.Controls.Add(lblchitiet8);
            groupBox1.Controls.Add(lblchitiet4);
            groupBox1.Controls.Add(txtChiTiet2);
            groupBox1.Controls.Add(lblchitiet2);
            groupBox1.Controls.Add(txtChiTiet1);
            groupBox1.Controls.Add(lblchitiet1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(813, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 621);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết";
            // 
            // txtMSV
            // 
            txtMSV.Location = new Point(137, 361);
            txtMSV.Name = "txtMSV";
            txtMSV.Size = new Size(244, 31);
            txtMSV.TabIndex = 32;
            txtMSV.Visible = false;
            // 
            // cbBoxGenDer4
            // 
            cbBoxGenDer4.FormattingEnabled = true;
            cbBoxGenDer4.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbBoxGenDer4.Location = new Point(137, 289);
            cbBoxGenDer4.Name = "cbBoxGenDer4";
            cbBoxGenDer4.Size = new Size(244, 33);
            cbBoxGenDer4.TabIndex = 31;
            cbBoxGenDer4.SelectedIndexChanged += cbBoxGenDer4_SelectedIndexChanged;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(151, 567);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(150, 31);
            txtGender.TabIndex = 30;
            txtGender.Visible = false;
            // 
            // valueLop
            // 
            valueLop.Location = new Point(243, 568);
            valueLop.Name = "valueLop";
            valueLop.Size = new Size(150, 31);
            valueLop.TabIndex = 29;
            valueLop.Visible = false;
            // 
            // valueCN
            // 
            valueCN.Location = new Point(54, 567);
            valueCN.Name = "valueCN";
            valueCN.Size = new Size(150, 31);
            valueCN.TabIndex = 28;
            valueCN.Visible = false;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(166, 497);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 27;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txt2
            // 
            txt2.Location = new Point(137, 289);
            txt2.Name = "txt2";
            txt2.Size = new Size(244, 31);
            txt2.TabIndex = 26;
            txt2.Visible = false;
            // 
            // txt1
            // 
            txt1.Location = new Point(137, 200);
            txt1.Name = "txt1";
            txt1.Size = new Size(244, 31);
            txt1.TabIndex = 25;
            txt1.Visible = false;
            // 
            // cbBoxLop
            // 
            cbBoxLop.FormattingEnabled = true;
            cbBoxLop.Location = new Point(137, 433);
            cbBoxLop.Name = "cbBoxLop";
            cbBoxLop.Size = new Size(244, 33);
            cbBoxLop.TabIndex = 24;
            cbBoxLop.SelectedIndexChanged += cbBoxLop_SelectedIndexChanged;
            // 
            // cbBoxChuyenNganh
            // 
            cbBoxChuyenNganh.FormattingEnabled = true;
            cbBoxChuyenNganh.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Công Nghệ Phần Mềm", "Hệ Thống Thông Tin", "An Toàn Thông Tin" });
            cbBoxChuyenNganh.Location = new Point(137, 359);
            cbBoxChuyenNganh.Name = "cbBoxChuyenNganh";
            cbBoxChuyenNganh.Size = new Size(244, 33);
            cbBoxChuyenNganh.TabIndex = 23;
            cbBoxChuyenNganh.SelectedIndexChanged += cbBoxChuyenNganh_SelectedIndexChanged;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(302, 497);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "&Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(6, 497);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(116, 34);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "&Thêm";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // lblchitiet3
            // 
            lblchitiet3.AutoSize = true;
            lblchitiet3.Location = new Point(42, 292);
            lblchitiet3.Name = "lblchitiet3";
            lblchitiet3.Size = new Size(80, 25);
            lblchitiet3.TabIndex = 17;
            lblchitiet3.Text = "GioiTinh:";
            // 
            // dtpChiTiet3
            // 
            dtpChiTiet3.Format = DateTimePickerFormat.Short;
            dtpChiTiet3.Location = new Point(137, 200);
            dtpChiTiet3.Name = "dtpChiTiet3";
            dtpChiTiet3.Size = new Size(244, 31);
            dtpChiTiet3.TabIndex = 16;
            // 
            // lblchitiet9
            // 
            lblchitiet9.AutoSize = true;
            lblchitiet9.Location = new Point(50, 433);
            lblchitiet9.Name = "lblchitiet9";
            lblchitiet9.Size = new Size(72, 25);
            lblchitiet9.TabIndex = 14;
            lblchitiet9.Text = "TenLop:";
            // 
            // lblchitiet8
            // 
            lblchitiet8.AutoSize = true;
            lblchitiet8.Location = new Point(0, 367);
            lblchitiet8.Name = "lblchitiet8";
            lblchitiet8.Size = new Size(128, 25);
            lblchitiet8.TabIndex = 12;
            lblchitiet8.Text = "ChuyenNganh:";
            // 
            // lblchitiet4
            // 
            lblchitiet4.AutoSize = true;
            lblchitiet4.Location = new Point(39, 200);
            lblchitiet4.Name = "lblchitiet4";
            lblchitiet4.Size = new Size(92, 25);
            lblchitiet4.TabIndex = 4;
            lblchitiet4.Text = "NgaySinh:";
            // 
            // txtChiTiet2
            // 
            txtChiTiet2.Location = new Point(137, 121);
            txtChiTiet2.Name = "txtChiTiet2";
            txtChiTiet2.Size = new Size(244, 31);
            txtChiTiet2.TabIndex = 3;
            // 
            // lblchitiet2
            // 
            lblchitiet2.AutoSize = true;
            lblchitiet2.Location = new Point(59, 127);
            lblchitiet2.Name = "lblchitiet2";
            lblchitiet2.Size = new Size(66, 25);
            lblchitiet2.TabIndex = 2;
            lblchitiet2.Text = "HoTen:";
            // 
            // txtChiTiet1
            // 
            txtChiTiet1.Location = new Point(137, 49);
            txtChiTiet1.Name = "txtChiTiet1";
            txtChiTiet1.Size = new Size(244, 31);
            txtChiTiet1.TabIndex = 1;
            // 
            // lblchitiet1
            // 
            lblchitiet1.AutoSize = true;
            lblchitiet1.Location = new Point(13, 55);
            lblchitiet1.Name = "lblchitiet1";
            lblchitiet1.Size = new Size(109, 25);
            lblchitiet1.TabIndex = 0;
            lblchitiet1.Text = "MaSinhVien:";
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(803, 67);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 621);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 621);
            panel3.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvAdmin);
            groupBox3.Controls.Add(panel2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(803, 541);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvAdmin
            // 
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Dock = DockStyle.Fill;
            dgvAdmin.Location = new Point(3, 27);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.RowHeadersWidth = 62;
            dgvAdmin.RowTemplate.Height = 33;
            dgvAdmin.Size = new Size(797, 424);
            dgvAdmin.TabIndex = 4;
            dgvAdmin.CellContentClick += dgvAdmin_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSinhVien);
            panel2.Controls.Add(btnMonHoc);
            panel2.Controls.Add(btnDangXuat);
            panel2.Controls.Add(btnTaiKhan);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 87);
            panel2.TabIndex = 3;
            // 
            // btnSinhVien
            // 
            btnSinhVien.Location = new Point(53, 33);
            btnSinhVien.Name = "btnSinhVien";
            btnSinhVien.Size = new Size(112, 34);
            btnSinhVien.TabIndex = 3;
            btnSinhVien.Text = "Sinh viên";
            btnSinhVien.UseVisualStyleBackColor = true;
            btnSinhVien.Click += btnSinhVien_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(lblTimKiem);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(803, 80);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(537, 34);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(199, 36);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(334, 31);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(56, 39);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(137, 25);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Nhập thông tin:";
            // 
            // ChuongTrinhAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 688);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ChuongTrinhAdmin";
            Text = "ChuongTrinhAdmin";
            Load += ChuongTrinhAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTieuDe;
        private Button btnTaiKhan;
        private Button btnMonHoc;
        private Button btnDangXuat;
        private GroupBox groupBox1;
        private Splitter splitter1;
        private Panel panel3;
        private GroupBox groupBox3;
        private Panel panel2;
        private GroupBox groupBox2;
        private Label lblTimKiem;
        private TextBox txtChiTiet1;
        private Label lblchitiet1;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label lblchitiet9;
        private Label lblchitiet8;
        private Label lblchitiet4;
        private TextBox txtChiTiet2;
        private Label lblchitiet2;
        private DateTimePicker dtpChiTiet3;
        private Label lblchitiet3;
        private Button btnXoa;
        private Button btnLuu;
        private DataGridView dgvAdmin;
        private Button btnSinhVien;
        private ComboBox cbBoxLop;
        private ComboBox cbBoxChuyenNganh;
        private TextBox txt2;
        private TextBox txt1;
        private Button btnSua;
        private TextBox valueLop;
        private TextBox valueCN;
        private TextBox txtGender;
        private ComboBox cbBoxGenDer4;
        private TextBox txtMSV;
    }
}