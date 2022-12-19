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

    public partial class Form10_2 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String id_taixe;
        public Form10_2()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.id_taixe = id_taixe;
            f.Show();
            this.Close();
        }

        private void Form10_2_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dsdonhangdanhan '" + id_taixe + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
