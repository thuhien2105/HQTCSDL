using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }
        public String id_nhanvien;
        public String id_hopdong;
        public String tenquan;
        public String masothue;
        public String email;
        public String sdt;
        public String diachi;
        public String tennguoidaidien;
        public String ngayhieuluc;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        private void Form19_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec thongtinhopdong '" + id_hopdong + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                masothue = reader["Ma so thue"].ToString();
                email = reader["Email"].ToString();
                sdt = reader["So dien thoai"].ToString();
                diachi = reader["Thanh pho/Quan"].ToString();
                tennguoidaidien = reader["Nguoi dai dien"].ToString();
                tenquan = reader["Ten quan"].ToString();
                ngayhieuluc = reader["Thoi gian het hieu luc"].ToString();
            }
            label19.Text = tenquan;
            label21.Text = masothue;
            label22.Text = email;
            label23.Text = sdt;
            label24.Text = diachi;
            label25.Text = tennguoidaidien;
            label29.Text = ngayhieuluc;
            label30.Text = id_hopdong;
            txtNgayHieuLuc.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18();
            form.id_nhanvien = id_nhanvien;
            form.Show();
            this.Close();
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            ngayhieuluc = txtNgayHieuLuc.Text;
            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec giahanhopdong '" + id_hopdong + "','" + ngayhieuluc + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNgayHieuLuc.Show();
        }
    }
}
