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
    public partial class Form1_1 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String tendangnhap;
        public String matkhau;
        public String hoten;
        public String sdt;
        public String diachi;
        public String email;
        public Form1_1()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }

        private void Form1_1_Load(object sender, EventArgs e)
        {

        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            tendangnhap = txttendangnhap.Text;
            matkhau = txtmatkhau.Text;
            hoten = txthoten.Text;
            sdt = txtsdt.Text;
            diachi = txtdiachi.Text;
            email = txtemail.Text;

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec sp_signup '" + tendangnhap + "','" + matkhau + "',N'" + hoten + "'," + sdt + ",N'" + diachi + "','" + email + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }
    }
}
