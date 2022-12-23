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
    public partial class Form13 : Form
    {
        public String id_doitac;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form13()
        {
            InitializeComponent();
            connectionString = @"Data Source=PC\SQLEXPRESS;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String date1 = dateTimePicker1.ToString();
            String date2 = dateTimePicker2.ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec xemDoanhthu '"+id_doitac+"' '"+date1+"','"+date2+"'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
        
        }
    }
}
