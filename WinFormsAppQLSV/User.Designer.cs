namespace WinFormsAppQLSV
{
    partial class User
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
            grb = new GroupBox();
            dgvList = new DataGridView();
            groupBox2 = new GroupBox();
            cbBoxGender = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            button4 = new Button();
            SuaTT = new Button();
            DKMonHoc = new Button();
            Xemtkb = new Button();
            txtTenDN = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtChuyenNganh = new TextBox();
            label5 = new Label();
            txtLop = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtHoTen = new TextBox();
            label2 = new Label();
            txtmsv = new TextBox();
            label1 = new Label();
            grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grb
            // 
            grb.Controls.Add(dgvList);
            grb.Dock = DockStyle.Top;
            grb.Location = new Point(0, 0);
            grb.Name = "grb";
            grb.Size = new Size(958, 331);
            grb.TabIndex = 0;
            grb.TabStop = false;
            grb.Text = "Thời khóa biểu";
            grb.UseWaitCursor = true;
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(3, 27);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 62;
            dgvList.RowTemplate.Height = 33;
            dgvList.Size = new Size(952, 301);
            dgvList.TabIndex = 0;
            dgvList.UseWaitCursor = true;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbBoxGender);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(SuaTT);
            groupBox2.Controls.Add(DKMonHoc);
            groupBox2.Controls.Add(Xemtkb);
            groupBox2.Controls.Add(txtTenDN);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtChuyenNganh);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLop);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtHoTen);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtmsv);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 337);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(958, 246);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sinh viên";
            groupBox2.UseWaitCursor = true;
            // 
            // cbBoxGender
            // 
            cbBoxGender.FormattingEnabled = true;
            cbBoxGender.Items.AddRange(new object[] { "Nam ", "Nữ" });
            cbBoxGender.Location = new Point(126, 204);
            cbBoxGender.Name = "cbBoxGender";
            cbBoxGender.Size = new Size(208, 33);
            cbBoxGender.TabIndex = 19;
            cbBoxGender.UseWaitCursor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(128, 154);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(206, 31);
            dtpNgaySinh.TabIndex = 18;
            dtpNgaySinh.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.Location = new Point(781, 200);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 17;
            button4.Text = "Đăng Xuất";
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // SuaTT
            // 
            SuaTT.Location = new Point(745, 132);
            SuaTT.Name = "SuaTT";
            SuaTT.Size = new Size(180, 34);
            SuaTT.TabIndex = 16;
            SuaTT.Text = "Sửa thông tin";
            SuaTT.UseVisualStyleBackColor = true;
            SuaTT.UseWaitCursor = true;
            // 
            // DKMonHoc
            // 
            DKMonHoc.Location = new Point(745, 75);
            DKMonHoc.Name = "DKMonHoc";
            DKMonHoc.Size = new Size(180, 34);
            DKMonHoc.TabIndex = 15;
            DKMonHoc.Text = "Đăng kí môn học";
            DKMonHoc.UseVisualStyleBackColor = true;
            DKMonHoc.UseWaitCursor = true;
            // 
            // Xemtkb
            // 
            Xemtkb.Location = new Point(745, 25);
            Xemtkb.Name = "Xemtkb";
            Xemtkb.Size = new Size(180, 34);
            Xemtkb.TabIndex = 14;
            Xemtkb.Text = "Xem Thời khóa biểu";
            Xemtkb.UseVisualStyleBackColor = true;
            Xemtkb.UseWaitCursor = true;
            Xemtkb.Click += Xemtkb_Click;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(509, 157);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(202, 31);
            txtTenDN.TabIndex = 13;
            txtTenDN.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 160);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 12;
            label7.Text = "TenDangNhap:";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 209);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 10;
            label6.Text = "Giới Tính:";
            label6.UseWaitCursor = true;
            // 
            // txtChuyenNganh
            // 
            txtChuyenNganh.Location = new Point(509, 93);
            txtChuyenNganh.Name = "txtChuyenNganh";
            txtChuyenNganh.Size = new Size(202, 31);
            txtChuyenNganh.TabIndex = 9;
            txtChuyenNganh.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 99);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 8;
            label5.Text = "ChuyenNganh:";
            label5.UseWaitCursor = true;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(509, 27);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(202, 31);
            txtLop.TabIndex = 7;
            txtLop.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 33);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 6;
            label4.Text = "Lop:";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "NgaySinh:";
            label3.UseWaitCursor = true;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(128, 90);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(202, 31);
            txtHoTen.TabIndex = 3;
            txtHoTen.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "HoTen:";
            label2.UseWaitCursor = true;
            // 
            // txtmsv
            // 
            txtmsv.Location = new Point(128, 30);
            txtmsv.Name = "txtmsv";
            txtmsv.Size = new Size(202, 31);
            txtmsv.TabIndex = 1;
            txtmsv.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "MaSinhVien:";
            label1.UseWaitCursor = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 583);
            Controls.Add(groupBox2);
            Controls.Add(grb);
            Name = "User";
            Text = "Sinh Viên";
            UseWaitCursor = true;
            Load += User_Load;
            grb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb;
        private DataGridView dgvList;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtChuyenNganh;
        private Label label5;
        private TextBox txtLop;
        private Label label4;
        private Label label3;
        private TextBox txtHoTen;
        private Label label2;
        private TextBox txtmsv;
        private Label label1;
        private Button SuaTT;
        private Button DKMonHoc;
        private Button Xemtkb;
        private TextBox txtTenDN;
        private Label label7;
        private Button button4;
        private ComboBox cbBoxGender;
        private DateTimePicker dtpNgaySinh;
    }
}