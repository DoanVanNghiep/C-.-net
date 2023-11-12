namespace QuanLySinhVien
{
    partial class ChuongTrinhDangNhap
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
            lblMain = new Label();
            groupBox1 = new GroupBox();
            splitter1 = new Splitter();
            dgvTKB = new DataGridView();
            panel2 = new Panel();
            btnLogin = new Button();
            btnExit = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            groupBox3 = new GroupBox();
            dgvThongTin = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKB).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMain);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 108);
            panel1.TabIndex = 0;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblMain.Location = new Point(233, 20);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(480, 70);
            lblMain.TabIndex = 0;
            lblMain.Text = "Thông tin sinh viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitter1);
            groupBox1.Controls.Add(dgvTKB);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(532, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 531);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời khóa biểu";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 87);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 441);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // dgvTKB
            // 
            dgvTKB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTKB.Dock = DockStyle.Fill;
            dgvTKB.Location = new Point(3, 87);
            dgvTKB.Name = "dgvTKB";
            dgvTKB.RowHeadersWidth = 62;
            dgvTKB.RowTemplate.Height = 33;
            dgvTKB.Size = new Size(479, 441);
            dgvTKB.TabIndex = 0;
            dgvTKB.CellContentClick += dgvTKB_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 60);
            panel2.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(94, 20);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "&Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(268, 20);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 0;
            btnExit.Text = "&Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 116);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 2;
            label2.Text = "Nhập thông tin:";
            label2.Click += label2_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(439, 56);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(87, 31);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "&Sreach...";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(155, 56);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(278, 31);
            txtTimKiem.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvThongTin);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(532, 415);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // dgvThongTin
            // 
            dgvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongTin.Dock = DockStyle.Fill;
            dgvThongTin.Location = new Point(3, 27);
            dgvThongTin.Name = "dgvThongTin";
            dgvThongTin.RowHeadersWidth = 62;
            dgvThongTin.RowTemplate.Height = 33;
            dgvThongTin.Size = new Size(526, 385);
            dgvThongTin.TabIndex = 0;
            // 
            // ChuongTrinhDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 639);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "ChuongTrinhDangNhap";
            Text = "Thông tin sinh viên";
            Load += ChuongTrinhDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTKB).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongTin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvTKB;
        private DataGridView dgvThongTin;
        private Panel panel2;
        private Button btnLogin;
        private Button btnExit;
        private Splitter splitter1;
    }
}