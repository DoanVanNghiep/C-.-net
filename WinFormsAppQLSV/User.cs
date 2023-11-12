using QuanLySinhVien;
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

namespace WinFormsAppQLSV
{
    public partial class User : Form
    {
        SqlConnection con;

        DataSet dataSet;


        SqlDataAdapter adapter;

        public User()
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
            dgvList.DataSource = dataSet.Tables[0];
            dgvList.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // khai báo đối tượng connection
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Thinkpad\\source\\repos\\WinFormsAppQLSV\\WinFormsAppQLSV\\QLSV.mdf;Integrated Security=True";
            con.Open();
        }
        private void Xemtkb_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            String query = "select t.MonHocID,m.TenMonHoc,t.ThoiKhoaBieuID,l.TenLop,m.TinChi,m.GiangVien,t.ThoiGian,t.DiaDiemHoc from ThoiKhoaBieu t inner join MonHoc m on t.MonHocID = m.MonHocID inner join Lop l on t.LopID = l.LopID inner join SinhVien s on l.LopID = s.LopID inner join TaiKhoan tk on s.MaSinhVien = tk.SinhVienID where tk.TenDangNhap like 'dvn01'";
            LoadDuLieu(query);
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
