using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien
{
    public partial class Form12 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public Form12()
        {
            InitializeComponent();
            _connectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            String ttk = this.textBox1.Text;
            String email = this.textBox2.Text;
            String dc = this.textBox3.Text;
            String sdt = this.textBox4.Text;
            String tnh = this.textBox5.Text;
            String stk = this.textBox6.Text;
            String id = this.textBox7.Text;

            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "Update [DOI TAC] set tentaikhoan = '" + ttk + "', Email ='" + email + "',[Thanh pho/Quan] =N'" + dc + "',[So dien thoai] ='" + sdt + "',[Ten Ngan hang] ='" + tnh + "',[So tai khoan] = '" + stk + "' where [Ma doi tac] = '" + id + "' ";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
