using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form6 : Form
    {
        public String id_khachhang;
        public String id_donhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form6()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbMaDonHang.SelectedItem;
            id_donhang = (String)row.Row["id_donhang"];

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec tinhtrangdonhang '" + id_donhang + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {     
                lblTrangThai.Text = reader["Tinh trang don hang"].ToString();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec donhang_dangduocthuchien '"+id_khachhang+"'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbMaDonHang.ValueMember = "id_donhang";
            cbbMaDonHang.DisplayMember = "id_donhang";
            cbbMaDonHang.DataSource = table;
            cbbMaDonHang.SelectedIndex = -1;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec huydonhang '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
