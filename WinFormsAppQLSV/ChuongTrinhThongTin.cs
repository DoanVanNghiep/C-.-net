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

namespace QuanLySinhVien
{
    public partial class ChuongTrinhDangNhap : Form
    {
        SqlConnection con;

        DataSet dataSet;

        SqlDataAdapter adapter;

        private void LoadDuLieuThongTin(String sql)
        {
            //tạo đối tượng DataSet
            dataSet = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            adapter = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            adapter.Fill(dataSet);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvThongTin.DataSource = dataSet.Tables[0];
            dgvThongTin.Refresh();
        }
        private void LoadDuLieuTKB(String sql)
        {
            //tạo đối tượng DataSet
            dataSet = new DataSet();
            //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
            adapter = new SqlDataAdapter(sql, con);
            //Dùng phương thức Fill của DataAdapter để đổ dữ liệu từ DataSource tới DataSet
            adapter.Fill(dataSet);
            //Gắn dữ liệu từ DataSet lên DataGridView
            dgvTKB.DataSource = dataSet.Tables[0];
            dgvTKB.Refresh();
        }

        public ChuongTrinhDangNhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChuongTrinhDangNhap_Load(object sender, EventArgs e)
        {
            // khai báo đối tượng connection
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Thinkpad\\source\\repos\\WinFormsAppQLSV\\WinFormsAppQLSV\\QLSV.mdf;Integrated Security=True";
            con.Open();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //chức năng tìm kiếm 
            String keyword = txtTimKiem.Text.Trim();
            //Viet cau lenh SQL cho tim kiem
            String sqlThongTin = "SELECT MaSinhVien,HoTen,c.TenChuyenNganh FROM SinhVien s inner join ChuyenNganh c on s.ChuyenNganhID = c.ChuyenNganhID";
            String sqlTKB = "select s.MaSinhVien,s.HoTen,l.TenLop,m.TenMonHoc,tkb.ThoiGian,tkb.DiaDiemHoc from ThoiKhoaBieu tkb inner join Lop l on tkb.LopID = l.LopID inner join MonHoc m on tkb.MonHocID = m.MonHocID inner join SinhVien s on l.LopID = s.LopID";
            String dk = "";

            if (keyword == null)
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm. VUI LÒNG NHẬP!");
            }
            else
            {
                dk += " where s.MaSinhVien = " + txtTimKiem.Text + " or s.HoTen like N'" + txtTimKiem.Text + "'";
            }

            if (dk != "")
            {
                sqlThongTin += dk;
                sqlTKB += dk;
            }


            LoadDuLieuThongTin(sqlThongTin);
            LoadDuLieuTKB(sqlTKB);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void dgvTKB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
