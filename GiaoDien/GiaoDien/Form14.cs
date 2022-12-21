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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GiaoDien
{
    public partial class Form14 : Form
    {
        public String id_doitac;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public Form14()
        {
            InitializeComponent();
            _connectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tencn=this.textBox1.Text;
            String dc = this.textBox2.Text;
            String tgm = this.textBox3.Text;  
            String tgd=this.textBox4.Text; 
            String id=this.textBox5.Text;

            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "exec updateChinhanh '"+tencn+"','"+dc+"','"+tgm+"','"+tgd+"','"+id+"','"+id_doitac+"' ";
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
            String id = this.textBox6.Text;
            String madt=this.textBox7.Text;
            String tennh=this.textBox8.Text;
            String stk=this.textBox9.Text; 
            String tgm=this.textBox10.Text;
            String tgd=this.textBox11.Text;

            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "exec themChinhanh '" + id + "','" + madt + "','" + tennh + "','" + stk + "','" + tgm + "','" + tgd + "' ";
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
            String macn=this.textBox12.Text;
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            String sql = "delete from [CHI NHANH] where id_chinhanh= ' "+macn+" ' and [Ma doi tac]='"+id_doitac+"' ";
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
