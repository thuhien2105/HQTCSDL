using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GiaoDien
{
    public partial class Form1 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public Form1()
        {
            InitializeComponent();
            _connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            String tendangnhap = this.txtTenDangNhap.Text;
            String matkhau = this.txtMatKhau.Text;
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec sp_login '"+tendangnhap+"','"+matkhau+"'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Đăng nhập thành công");
                string loaitaikhoan = reader["loaitaikhoan"].ToString();
                MessageBox.Show(loaitaikhoan);
                if (loaitaikhoan=="Khach hang")
                {
                    //lay id_khachhang
                    String id_khachhang = reader["MaKH"].ToString();
                    //vao form trang chu cua khach hang
                    Form2 form2 = new Form2();
                    form2.id_khachhang= id_khachhang;
                    //form2.id_f2 = id;
                    form2.Show();
                    this.Hide();
                }
                else if (loaitaikhoan=="Tai xe")
                {
                    //lay id_taixe 
                    String id_taixe = reader["MaTX"].ToString();
                    MessageBox.Show(id_taixe);
                    //vao form trang chu cua khach hang
                    Form10 form10 = new Form10();
                    form10.id_taixe = id_taixe;
                    form10.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Not found !!!");
            reader.Close();
            //Bước 5: Đóng kết nối
            _connection.Close();

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
