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
    public partial class Form16 : Form
    {

        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public Form16()
        {
            InitializeComponent();
            _connectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mieuta = this.textBox1.Text;
            String gia=this.textBox2.Text;
            String tinhtrang=this.textBox3.Text;
            String tenmon=this.textBox4.Text;

            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "exec updateMonan '" + mieuta + "','" + gia + "','" + tinhtrang + "','" + tenmon + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String tenmon = this.textBox5.Text;
            String madt=this.textBox6.Text;
            String macn=this.textBox7.Text;
            String gia=this.textBox8.Text;
            String mieuta=this.textBox9.Text;
            String tinhtrang= this.textBox10.Text;

            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "exec themMonan '" + tenmon + "','" + madt + "','" + macn + "','" + gia + "','"+mieuta+"','"+tinhtrang+"'";
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
            String tenmon=this.textBox11.Text;


            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "delete from [THUC DON] where [Ten mon]='"+tenmon+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }
    }
}
