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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien
{
    public partial class Form2_1 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form2_1()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }
        public String id_khachhang;
        public String hoten;
        public String sdt;
        public String diachi;
        public String email;
        private void Form2_1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();

            btnCapNhat.Hide();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec thongtinkhachhang '"+id_khachhang+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                hoten = reader["Ho ten"].ToString();
                sdt = reader["So dien thoai"].ToString();
                diachi= reader["Ho ten"].ToString();
                email= reader["Email"].ToString();
            }
            label5.Text = hoten;
            label6.Text = sdt;
            label7.Text = diachi;
            label8.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoten = textBox1.Text;
            sdt= textBox2.Text;
            diachi = textBox3.Text;
            email= textBox4.Text;
            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec updatekhachhang '" + id_khachhang + "',N'" + hoten + "','" +sdt+"',N'"+diachi+"','"+email+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            btnCapNhat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form7 = new Form2();
            form7.id_khachhang = id_khachhang;
            form7.Show();
            this.Close();
        }
    }
}
