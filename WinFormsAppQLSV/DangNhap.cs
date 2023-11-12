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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using WinFormsAppQLSV;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLySinhVien
{
    public partial class DangNhap : Form
    {
        //Khai báo các biến toàn cục
        SqlConnection con;
        //Khai báo đối tượng thực hiện kết nối đến cơ sở dữ liệu
        SqlCommand cmd;
        //Khai báo đối tượng thực hiện các câu lệnh truy vấn
        SqlDataAdapter dap;
        //Khai báo đối tượng gắn kết DataSource với DataSet
        DataSet ds;


        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            // tạo đối tượng connection
            con = new SqlConnection();
            //truyền vào chuỗi kết nối tới cơ sở dữ liệu
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Thinkpad\\source\\repos\\QuanLySinhVien\\QuanLySinhVien\\QuanLySinhVien.mdf;Integrated Security=True";

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap ='" + txtTaiKhoan.Text + "' AND MatKhau='" + txtMatKhau.Text + "'";
                cmd = new SqlCommand(query, con);
                SqlDataReader dataReader = cmd.ExecuteReader();



                if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "12345")
                {
                    ChuongTrinhAdmin admin = new ChuongTrinhAdmin();
                    admin.Show();
                    this.Hide();

                }
                else
                {
                    if (dataReader.Read() == true)
                    {
                        User user = new User();
                        user.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ChuongTrinhDangNhap dangNhap = new ChuongTrinhDangNhap();
            dangNhap.Show();
            this.Hide();
        }
        public String valueLogin()
        {
            return txtTaiKhoan.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
