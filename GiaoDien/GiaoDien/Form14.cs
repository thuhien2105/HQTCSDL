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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GiaoDien
{
    public partial class Form14 : Form
    {
        public String id_doitac;
        public String id_chinhanh;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form14()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String dc = this.textBox2.Text;
            String tgm = this.textBox3.Text;
            String tgd = this.textBox4.Text;

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec updateChinhanh '" + dc + "','" + tgm + "','" + tgd + "','" + id_chinhanh + "','" + id_doitac + "' ";
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
            String tenchinhanhs = this.textBox1.Text;
            String tennh = this.textBox8.Text;
            String stk = this.textBox9.Text;
            String tgm = this.textBox10.Text;
            String tgd = this.textBox11.Text;
            String diachi = this.textBox5.Text;
            String sdt = this.textBox6.Text;

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec themChinhanh '" + id_doitac + "','" + tenchinhanhs + "','" + tennh + "','" + stk + "','" + tgm + "','" + tgd + "','" + diachi + "','" + sdt + "'";
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
            DataRowView row = (DataRowView)cbbTenChiNhanh.SelectedItem;
            id_chinhanh = (String)row.Row["id_chinhanh"];

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "delete from [CHI NHANH] where id_chinhanh= '" + id_chinhanh + "' and [Ma doi tac]='" + id_doitac + "' ";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            button4.Hide();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dschinhanh '" + id_doitac + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.ValueMember = "Ten";
            comboBox1.DisplayMember = "id_chinhanh";
            comboBox1.DataSource = table;
            comboBox1.SelectedIndex = -1;

            cbbTenChiNhanh.ValueMember = "Ten";
            cbbTenChiNhanh.DisplayMember = "id_chinhanh";
            cbbTenChiNhanh.DataSource = table;
            cbbTenChiNhanh.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.id_doitac = id_doitac;
            f.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            button4.Show();
            DataRowView row = (DataRowView)comboBox1.SelectedItem;
            id_chinhanh = (String)row.Row["id_chinhanh"];
        }
        
    }




}
