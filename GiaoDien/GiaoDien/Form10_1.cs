using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form10_1 : Form
    {
        public String id_khachhang;
        public String id_donhang;
        public String diachicuahang;
        public String diachinguoinhan;
        public String tenquan;
        public String sdtcuahang;
        public String sdtnguoinhan;
        public String trangthai;
        public String id_taixe;
        public String trangthaidonhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form10_1()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form10_1_Load(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec thongtinkhachhang '" + id_khachhang+"'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                label6.Text = reader["Ho ten"].ToString();
                label7.Text = reader["So dien thoai"].ToString();
                label5.Text = reader["Dia chi"].ToString();
            }

            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql_ = "exec thongtinchinhanh '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql_, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader_ = _command.ExecuteReader();
            if (reader_.Read())
            {

                label2.Text = reader_["Dia chi"].ToString();
                label3.Text = reader_["Ten"].ToString(); ;
                label4.Text = reader_["sdt"].ToString(); ;
            }


            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql__ = "exec tinhtrangdonhang '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql__, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader__ = _command.ExecuteReader();
            if (reader__.Read())
            {
                trangthaidonhang = reader__["Tinh trang don hang"].ToString();
                label8.Text = reader__["Tinh trang don hang"].ToString();
                label12.Text = reader__["Phi van chuyen"].ToString();
                label13.Text = reader__["Tong don hang"].ToString() ;
                label14.Text = reader__["Hinh thuc thanh toan"].ToString();
            }
            if (trangthaidonhang != "Giao hàng thành công")
            {
                button1.Hide();
            }
            else
            {
                button1.Show();
            }

        }

        private void btnTuChoiDon_Click(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec taixe_tuchoi '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            int reader = _command.ExecuteNonQuery();

            Form10 form10 =new Form10();
            form10.id_taixe = id_taixe;
            form10.Show();
            this.Close();

        }

        private void btnChuyenDonHang_Click(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec taixe_chuyentrangthai '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader= _command.ExecuteReader();


            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql__ = "exec tinhtrangdonhang '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql__, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader__ = _command.ExecuteReader();
            if (reader__.Read())
            {
                trangthaidonhang = reader__["Tinh trang don hang"].ToString();
                label8.Text = reader__["Tinh trang don hang"].ToString();
            }
            if (trangthaidonhang != "Giao hàng thành công")
            {
                button1.Hide();
            }
            else
            {
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.id_donhang = id_donhang;
            form10.id_taixe = id_taixe;
            form10.Show();
            this.Close();
        }
    }
}
