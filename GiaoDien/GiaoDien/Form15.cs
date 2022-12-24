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
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f=new Form16();
            f.id_doitac = id_doitac;
            f.id_chinhanh = id_chinhanh;
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)comboBox1.SelectedItem;
            id_chinhanh = (String)row.Row["id_chinhanh"];

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec xemTHucDon '" + id_doitac + "', '"+id_chinhanh+"' ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form15_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dschinhanh '" + id_doitac + "' ", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBox1.ValueMember = "id_chinhanh";
            comboBox1.DisplayMember = "Ten";
            comboBox1.DataSource = table;
            comboBox1.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 f=new Form11();
            f.id_doitac = id_doitac;
            f.Show();
            this.Close();
        }
    }
}
