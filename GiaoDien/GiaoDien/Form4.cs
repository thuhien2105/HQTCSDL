using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien
{
    public partial class Form4 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form4()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }

        public string tenquan;
        public string id_doitac;
        public string id_chinhanh;
        public string tenmon;
        public String soluong;
        public String id_donhang;
        public String id_khachhang;
        //public int tongtien = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            lblTenQuan.Text = tenquan;

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [CHI NHANH] WHERE [CHI NHANH].[Ma doi tac] ='" + id_doitac + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbChiNhanh.ValueMember = "id_chinhanh";
            cbbChiNhanh.DisplayMember = "Dia chi";
            cbbChiNhanh.DataSource = table;
            cbbChiNhanh.SelectedIndex = -1;

           
        }

        private void btnChonChiNhanh_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbChiNhanh.SelectedItem;
            id_chinhanh = (String)row.Row["id_chinhanh"];
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter_ = new SqlDataAdapter("SELECT [Ten mon], Gia, [Mieu ta] FROM [THUC DON] where [THUC DON].[Ma doi tac]='" + id_doitac + "' and [THUC DON].[Ma chi nhanh]='" + id_chinhanh + "'", connection);

            DataTable tablethucdon = new DataTable();
            adapter_.Fill(tablethucdon);
            cbbThucDon.DataSource = tablethucdon;
            cbbThucDon.ValueMember = "Ten mon";
            cbbThucDon.DisplayMember = "Ten mon";
            //cbbThucDon.DisplayMember = "Gia";
            //cbbThucDon.DisplayMember = "Mieu ta";
            cbbThucDon.SelectedIndex = -1;


            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec taodonhang '" + id_chinhanh + "','" + id_doitac + "','" + id_khachhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                id_donhang = reader["id_donhang"].ToString();
            }

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            soluong = numSoLuong.Value.ToString();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec taoctdonhang '"+id_donhang+"','"+id_chinhanh+"','"+id_doitac+"',N'"+tenmon+"',"+soluong;
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql_tong = "exec tinhtongdonhang '" + id_donhang + "'";
            _command = new SqlCommand(sql_tong, _connection);
            _command.Connection = _connection;
            SqlDataReader reader_tong = _command.ExecuteReader();

            if (reader_tong.Read())
            {
                lblTong.Text = "Tổng tiền món ăn: "+ reader_tong["Tong"].ToString();
            }

        }

        private void btnChonMonAn_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbThucDon.SelectedItem;
            tenmon = row.Row["Ten mon"].ToString();
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "SELECT * FROM [THUC DON] where [THUC DON].[Ma doi tac]='" + id_doitac + "' and [THUC DON].[Ma chi nhanh]='"+id_chinhanh+"' and [THUC DON].[Ten mon]= N'"+tenmon+"'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                lblGia.Text = reader["Gia"].ToString();
                lblMieuTa.Text = reader["Mieu ta"].ToString();
            }


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec huydonhang '"+id_donhang+"'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            Form2 form2= new Form2();
            form2.Show();
            this.Close();
        }

        private void btnDatDonHang_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec update_donhang '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            reader.Close();
            _connection.Close();
            Form5 form5= new Form5();
            form5.id_donhang = id_donhang;
            if (reader.Read())
            {
                form5.tongdonhang = reader["Tong don hang"].ToString();
                form5.phivanchuyen = reader["Phi van chuyen"].ToString();
            }
            form5.Show();
            this.Hide();
        }

    
    }
}
