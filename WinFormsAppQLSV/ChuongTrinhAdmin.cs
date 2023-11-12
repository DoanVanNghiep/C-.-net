using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.VisualBasic.Devices;

namespace QuanLySinhVien
{
    public partial class ChuongTrinhAdmin : Form
    {
        SqlConnection con;

        DataSet dataSet;

        SqlDataAdapter adapter;


        public ChuongTrinhAdmin()
        {
            InitializeComponent();
        }

        private void LoadDuLieu(String sql)
        {
            //tạo đối tượng DataSet
            dataSet = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            adapter = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            adapter.Fill(dataSet);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvAdmin.DataSource = dataSet.Tables[0];
            dgvAdmin.Refresh();
        }
        private void ChuongTrinhAdmin_Load(object sender, EventArgs e)
        {
            // khai báo đối tượng connection
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Thinkpad\\source\\repos\\WinFormsAppQLSV\\WinFormsAppQLSV\\QLSV.mdf;Integrated Security=True";
            con.Open();


            // hiện tiêu đề
            lblTieuDe.Text = "Xin chào, Admin";


        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            String query = "select s.MaSinhVien as MaSinhVien,s.HoTen,s.NgaySinh,l.TenLop,case when s.GioiTinh = 1 then N'Nam' when GioiTinh = 0 then N'Nữ' end as GioiTinh, c.TenChuyenNganh from SinhVien s inner join Lop l on s.LopID = l.LopID inner join ChuyenNganh c on s.ChuyenNganhID = c.ChuyenNganhID";
            LoadDuLieu(query);


            // ẩn hiện các nút
            btnSinhVien.Enabled = false;
            btnMonHoc.Enabled = true;
            btnTaiKhan.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            txtTimKiem.Enabled = true;
            lblTimKiem.Enabled = true;


            // tiêu đề
            lblTieuDe.Text = "Quản lý sinh viên";

            //
            lblchitiet1.Enabled = true;
            txtChiTiet1.Enabled = true;
            lblchitiet2.Enabled = true;
            txtChiTiet2.Enabled = true;
            lblchitiet3.Enabled = true;

            // ẩn hiện lable để thêm
            txt1.Visible = false;
            txt2.Visible = false;

            lblchitiet1.Text = "MaSinhVien:";
            lblchitiet2.Text = "HoTen:";
            lblchitiet3.Text = "GioiTinh:";
            cbBoxGenDer4.Visible = true;
            cbBoxGenDer4.Enabled = true;
            lblchitiet4.Text = "NgaySinh:";
            lblchitiet4.Visible = true;
            lblchitiet4.Enabled = true;
            dtpChiTiet3.Visible = true;
            lblchitiet8.Text = "ChuyenNganh:";
            lblchitiet8.Visible = true;
            cbBoxChuyenNganh.Visible = true;
            lblchitiet9.Text = "TenLop:";
            lblchitiet9.Visible = true;
            cbBoxLop.Visible = true;
            txtMSV.Visible = false;


        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM MonHoc";
            LoadDuLieu(query);

            //ẩn hiện các nút
            btnSinhVien.Enabled = true;
            btnMonHoc.Enabled = false;
            btnTaiKhan.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            txtTimKiem.Enabled = true;
            lblTimKiem.Enabled = true;

            //tiêu đề
            lblTieuDe.Text = "Quản lý môn học";

            //
            lblchitiet1.Enabled = true;
            txtChiTiet1.Enabled = true;
            lblchitiet2.Enabled = true;
            txtChiTiet2.Enabled = true;
            lblchitiet3.Enabled = true;

            // ẩn hiện lable để thêm
            lblchitiet1.Text = "MaMonHoc:";
            lblchitiet2.Text = "TenMH:";
            lblchitiet3.Text = "TinChi";
            txt1.Visible = true;
            lblchitiet4.Text = "GiangVien";
            txt2.Visible = true;
            cbBoxGenDer4.Visible = false;
            dtpChiTiet3.Visible = false;
            lblchitiet8.Visible = false;
            txtMSV.Visible = true;
            cbBoxChuyenNganh.Visible = false;
            lblchitiet9.Visible = false;
            cbBoxLop.Visible = false;
            txtMSV.Visible = false;

        }

        private void btnTaiKhan_Click(object sender, EventArgs e)
        {
            String query = "SELECT s.MaSinhVien,s.HoTen,t.TaiKhoanID,t.TenDangNhap,t.MatKhau FROM TaiKhoan t inner join SinhVien s on t.SinhVienID = s.MaSinhVien;";
            LoadDuLieu(query);

            // ẩn hiện các nút
            btnSinhVien.Enabled = true;
            btnTaiKhan.Enabled = false;
            btnMonHoc.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
            txtTimKiem.Enabled = true;
            lblTimKiem.Enabled = true;

            //tiêu đề
            lblTieuDe.Text = "Quản lý tài khoản";


            //
            lblchitiet1.Enabled = true;
            txtChiTiet1.Enabled = true;
            lblchitiet2.Enabled = true;
            txtChiTiet2.Enabled = true;
            lblchitiet3.Enabled = true;

            // ẩn hiện lable để thêm
            // ẩn hiện lable để thêm
            lblchitiet1.Text = "TaiKhoanID:";
            lblchitiet2.Text = "TenDN:";
            lblchitiet3.Text = "MatKhau";
            txt1.Visible = true;
            lblchitiet4.Text = "SinhVien";
            txt2.Visible = true;
            cbBoxGenDer4.Visible = false;
            dtpChiTiet3.Visible = false;
            lblchitiet8.Text = "SinhVienID";
            cbBoxChuyenNganh.Visible = false;
            lblchitiet9.Visible = false;
            cbBoxLop.Visible = false;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //chức năng tìm kiếm 
            String keyword = txtTimKiem.Text.Trim();
            //Viet cau lenh SQL cho tim kiem
            String sql = "SELECT * FROM ";
            String dk = "";

            if (btnSinhVien.Enabled == false)
            {
                if (keyword == null)
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm. VUI LÒNG NHẬP!");
                }
                else
                {
                    dk += "SinhVien where MaSinhVien like '%" + txtTimKiem.Text + "%' or HoTen like N'%" + txtTimKiem.Text + "%'";
                }

                if (dk != "") sql += dk;

                LoadDuLieu(sql);
            }
            if (btnMonHoc.Enabled == false)
            {
                if (keyword == null)
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm. VUI LÒNG NHẬP!");
                }
                else
                {
                    dk += "MonHoc where MonHocID like '%" + txtTimKiem.Text + "%' or TenMonHoc like N'%" + txtTimKiem.Text + "%'";
                }

                if (dk != "") sql += dk;

                LoadDuLieu(sql);
            }
            if (btnTaiKhan.Enabled == false)
            {
                if (keyword == null)
                {
                    MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm. VUI LÒNG NHẬP!");
                }
                else
                {
                    dk += "TaiKHoan where TaiKhoanID like '%" + txtTimKiem.Text + "%' or TenDangNhap like N'" + txtTimKiem.Text + "'";
                }

                if (dk != "") sql += dk;

                LoadDuLieu(sql);
            }
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSinhVien.Enabled == false)
            {
                try
                {
                    txtChiTiet1.Text = dgvAdmin[0, e.RowIndex].Value.ToString();
                    txtChiTiet2.Text = dgvAdmin[1, e.RowIndex].Value.ToString();
                    dtpChiTiet3.Value = (DateTime)dgvAdmin[2, e.RowIndex].Value;
                    cbBoxGenDer4.Text = dgvAdmin[4, e.RowIndex].Value.ToString();
                    cbBoxChuyenNganh.Text = dgvAdmin[5, e.RowIndex].Value.ToString();
                    cbBoxLop.Text = dgvAdmin[3, e.RowIndex].Value.ToString();
                }
                catch (Exception)
                {
                }
            }
            if (btnMonHoc.Enabled == false)
            {
                try
                {
                    txtChiTiet1.Text = dgvAdmin[0, e.RowIndex].Value.ToString();
                    txtChiTiet2.Text = dgvAdmin[1, e.RowIndex].Value.ToString();
                    txt1.Text = dgvAdmin[3, e.RowIndex].Value.ToString();
                    txt2.Text = dgvAdmin[2, e.RowIndex].Value.ToString();
                }
                catch (Exception)
                {
                }
            }
            if (btnTaiKhan.Enabled == false)
            {
                try
                {
                    txtChiTiet1.Text = dgvAdmin[2, e.RowIndex].Value.ToString();
                    txtChiTiet2.Text = dgvAdmin[3, e.RowIndex].Value.ToString();
                    txt1.Text = dgvAdmin[1, e.RowIndex].Value.ToString();
                    txt2.Text = dgvAdmin[4, e.RowIndex].Value.ToString();
                    txtMSV.Text = dgvAdmin[0, e.RowIndex].Value.ToString();
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand command;

            if (btnSinhVien.Enabled == false)
            {
                String sql = "select s.MaSinhVien as MaSinhVien,s.HoTen,s.NgaySinh,l.TenLop,case when s.GioiTinh = 1 then N'Nam' when GioiTinh = 0 then N'Nữ' end as GioiTinh, c.TenChuyenNganh from SinhVien s inner join Lop l on s.LopID = l.LopID inner join ChuyenNganh c on s.ChuyenNganhID = c.ChuyenNganhID";

                command = con.CreateCommand();
                command.CommandText = "delete from TaiKhoan where SinhVienID = " + txtChiTiet1.Text;
                command.ExecuteNonQuery();
                command.CommandText = "delete from SinhVien where MaSinhVien = " + txtChiTiet1.Text;
                command.ExecuteNonQuery();

                LoadDuLieu(sql);

            }
            if (btnMonHoc.Enabled == false)
            {
                String sql = "select * from MonHoc";

                command = con.CreateCommand();
                command.CommandText = "delete from ThoiKhoaBieu where MonHocID = " + txtChiTiet1.Text;
                command.ExecuteNonQuery();
                command.CommandText = "delete from MonHoc where MonHocID = " + txtChiTiet1.Text;
                command.ExecuteNonQuery();

                LoadDuLieu(sql);

            }
            if (btnTaiKhan.Enabled == false)
            {
                String sql = "SELECT s.MaSinhVien,s.HoTen,t.TaiKhoanID,t.TenDangNhap,t.MatKhau FROM TaiKhoan t inner join SinhVien s on t.SinhVienID = s.MaSinhVien;";

                command = con.CreateCommand();
                command.CommandText = "delete from TaiKhoan where TaiKhoanID = " + txtChiTiet1.Text;
                command.ExecuteNonQuery();
                LoadDuLieu(sql);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String sreachText = txtChiTiet1.Text;

            SqlCommand command;


            if (btnSinhVien.Enabled == false)
            {

                String query = "select s.MaSinhVien as MaSinhVien,s.HoTen,s.NgaySinh,l.TenLop,case when s.GioiTinh = 1 then N'Nam' when GioiTinh = 0 then N'Nữ' end as GioiTinh, c.TenChuyenNganh from SinhVien s inner join Lop l on s.LopID = l.LopID inner join ChuyenNganh c on s.ChuyenNganhID = c.ChuyenNganhID";


                command = con.CreateCommand();
                command.CommandText = "insert into SinhVien(MaSinhVien, HoTen, NgaySinh, LopID,GioiTinh,ChuyenNganhID) VALUES ( '" + txtChiTiet1.Text + "',N'" + txtChiTiet2.Text + "' ,'" + dtpChiTiet3.Text + "'," + valueLop.Text + "," + txtGender.Text + "," + valueCN.Text + ")";
                command.ExecuteNonQuery();
                LoadDuLieu(query);

            }

            if (btnMonHoc.Enabled == false)
            {
                String query = "SELECT * FROM MonHoc";

                command = con.CreateCommand();
                command.CommandText = "inser into MonHoc(MonHocID,TenMonHoc,TinChi,GiangVien) VALUES (" + txtChiTiet1.Text + ", N'" + txtChiTiet2.Text + "'," + txt1.Text + ",N'" + txt2.Text + "' )";
                command.ExecuteNonQuery();
                LoadDuLieu(query);



            }
            if (btnTaiKhan.Enabled == false)
            {
                String query = "SELECT s.MaSinhVien,s.HoTen,t.TaiKhoanID,t.TenDangNhap,t.MatKhau FROM TaiKhoan t inner join SinhVien s on t.SinhVienID = s.MaSinhVien;";
                command = con.CreateCommand();
                command.CommandText = "insert into TaiKhoan(TaiKhoanID,TenDangNhap,MatKhau,SinhVienID) VALUES (" + txtChiTiet1.Text + ", '" + txtChiTiet2.Text + "','" + txt1.Text + "'," + txtMSV.Text + ")";
                command.ExecuteNonQuery();
                LoadDuLieu(query);
            }
        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy giá trị đã chọn trong comboBoxChuyenNganh
            String chuyenNganh = cbBoxChuyenNganh.SelectedItem.ToString();


            // Xóa các mục đã chọn trong comboBoxLop
            cbBoxLop.Items.Clear();
            // comboBox 
            if (chuyenNganh == "Công Nghệ Thông Tin")
            {
                valueCN.Text = "1";

                cbBoxLop.Items.Add("CNTTA");
                cbBoxLop.Items.Add("CNTTB");
                cbBoxLop.Items.Add("CNTTC");
                cbBoxLop.Items.Add("CNTTD");
            }
            if (chuyenNganh == "Công Nghệ Phần Mềm")
            {
                valueCN.Text = "2";
                cbBoxLop.Items.Add("CNPMA");
                cbBoxLop.Items.Add("CNPMA");
                cbBoxLop.Items.Add("CNPMB");
                cbBoxLop.Items.Add("CNPMC");
                cbBoxLop.Items.Add("CNPMD");
            }
            if (chuyenNganh == "Hệ Thống Thông Tin")
            {
                valueCN.Text = "3";
                cbBoxLop.Items.Add("HTTTA");
                cbBoxLop.Items.Add("HTTTB");
                cbBoxLop.Items.Add("HTTTC");
                cbBoxLop.Items.Add("HTTTD");
            }
            if (chuyenNganh == "An Toàn Thông Tin")
            {
                valueCN.Text = "4";
                cbBoxLop.Items.Add("ATTTA");
                cbBoxLop.Items.Add("ATTTB");
                cbBoxLop.Items.Add("ATTTC");
                cbBoxLop.Items.Add("ATTTD");
            }


        }

        private void cbBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy giá trị comboBoxLop
            String lop = cbBoxLop.SelectedItem.ToString();
            if (lop == "CNTTA")
            {
                valueLop.Text = "1";
            }
            if (lop == "CNTTB")
            {
                valueLop.Text = "2";

            }
            if (lop == "CNTTC")
            {
                valueLop.Text = "3";
            }
            if (lop == "CNTTD")
            {
                valueLop.Text = "4";
            }
            if (lop == "CNPMA")
            {
                valueLop.Text = "5";
            }
            if (lop == "CNPMB")
            {
                valueLop.Text = "6";
            }
            if (lop == "CNPMC")
            {
                valueLop.Text = "7";
            }
            if (lop == "CNPMD")
            {
                valueLop.Text = "8";
            }
            if (lop == "HTTTA")
            {
                valueLop.Text = "9";
            }
            if (lop == "HTTTB")
            {
                valueLop.Text = "10";
            }
            if (lop == "HTTTC")
            {
                valueLop.Text = "11";
            }
            if (lop == "HTTTD")
            {
                valueLop.Text = "12";
            }
            if (lop == "ATTTA")
            {
                valueLop.Text = "13";
            }
            if (lop == "ATTTB")
            {
                valueLop.Text = "14";
            }
            if (lop == "ATTTC")
            {
                valueLop.Text = "15";
            }
            if (lop == "ATTTD")
            {
                valueLop.Text = "16";
            }

        }

        private void cbBoxGenDer4_SelectedIndexChanged(object sender, EventArgs e)
        {
            String gender = cbBoxGenDer4.SelectedItem.ToString();

            if (gender == "Nam") txtGender.Text = "1";
            if (gender == "Nữ") txtGender.Text = "0";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand command;

            if (btnSinhVien.Enabled == false)
            {
                String query = "select s.MaSinhVien as MaSinhVien,s.HoTen,s.NgaySinh,l.TenLop,case when s.GioiTinh = 1 then N'Nam' when GioiTinh = 0 then N'Nữ' end as GioiTinh, c.TenChuyenNganh from SinhVien s inner join Lop l on s.LopID = l.LopID inner join ChuyenNganh c on s.ChuyenNganhID = c.ChuyenNganhID";
                command = con.CreateCommand();
                command.CommandText = "update SinhVien set MaSinhVien = '" + txtChiTiet1.Text + "', HoTen = N'" + txtChiTiet2.Text + "' ,NgaySinh = '" + dtpChiTiet3.Text + "', LopID = " + valueLop.Text + ", GioiTinh = " + txtGender.Text + ", ChuyenNganhID = " + valueCN.Text + ")";
                command.ExecuteNonQuery();
                LoadDuLieu(query);
            }
            if(btnMonHoc.Enabled == false)
            {
                String query = "SELECT * FROM MonHoc";

                command = con.CreateCommand();
                command.CommandText = "update MonHoc set MonHocID = " + txtChiTiet1.Text + ", TenMonHoc = N'" + txtChiTiet2.Text + "',TinChi " + txt1.Text + ",GiangVien = N'" + txt2.Text + "'";
                command.ExecuteNonQuery();
                LoadDuLieu(query);


            }
            if (btnTaiKhan.Enabled == false)
            {
                String query = "SELECT s.MaSinhVien,s.HoTen,t.TaiKhoanID,t.TenDangNhap,t.MatKhau FROM TaiKhoan t inner join SinhVien s on t.SinhVienID = s.MaSinhVien;";
                command = con.CreateCommand();
                command.CommandText = "update TaiKhoan set TaiKhoanID = " + txtChiTiet1.Text + ", TenDangNhap = '" + txtChiTiet2.Text + "', MatKhau = '" + txt1.Text + "', SinhVienID = " + txtMSV.Text + "";
                command.ExecuteNonQuery();
                LoadDuLieu(query);
            }
        }
    }
}
