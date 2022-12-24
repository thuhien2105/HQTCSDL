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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien
{
    public partial class Form16 : Form
    {

        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String id_doitac;
        public string id_chinhanh;
        public String tenmonan;
        public Form16()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mieuta = this.textBox1.Text;
            String gia=this.textBox2.Text;
            String tinhtrang=this.textBox3.Text;


            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec updateMonan '" + mieuta + "','" + gia + "','" + tinhtrang + "','" + "','" +tenmonan+"','"+id_doitac+"','"+id_chinhanh+"'";
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
            String gia=this.textBox8.Text;
            String mieuta=this.textBox9.Text;
            String tinhtrang= this.textBox10.Text;

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec themMonan '"+tenmonan+"','"+id_doitac+"','"+id_chinhanh+"','"+gia+"',N'"+mieuta+"'";
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
            


            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "delete from [THUC DON] where [Ten mon]='"+tenmonan+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec xemThucDon '" + id_doitac + "','" + id_chinhanh + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.ValueMember = "Ten mon";
            comboBox1.DisplayMember = "Ten mon";
            comboBox1.DataSource = table;

            comboBox1.SelectedIndex = -1;
            comboBox2.ValueMember = "Ten mon";
            comboBox2.DisplayMember = "Ten mon";
            comboBox2.DataSource = table;
            comboBox2.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)comboBox1.SelectedItem;
            tenmonan = (String)row.Row["Ten mon"];
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form15 f=new Form15();
            f.id_doitac=id_doitac;
            f.id_chinhanh=id_chinhanh;
            f.Show();
            this.Hide();
        }
    }


    
}
