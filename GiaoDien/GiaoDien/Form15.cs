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
    public partial class Form15 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String id_doitac;
        public String id_chinhanh;
        public Form15()
        {
            InitializeComponent();
            connectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f=new Form16();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec xemTHucDon '" + id_doitac + "', '"+id_chinhanh+"' ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form15_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select* from [THUC DON] where [Ma doi tac]= '" + id_doitac + "' ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.ValueMember = "Ma chi nhanh";
            comboBox1.DisplayMember = "Ten mon";
            comboBox1.DataSource = table;
            comboBox1.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }
    }
}
