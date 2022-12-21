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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
            dataGridView1.AutoGenerateColumns = false;
        }
        public String id_nhanvien;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOANDataSet5.dshopdong' table. You can move, or remove it, as needed.
            this.dshopdongTableAdapter.Fill(this.dOANDataSet5.dshopdong);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dshopdong", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDoiTac.ValueMember = "Ma doi tac";
            cbbDoiTac.DisplayMember = "Ten quan";
            cbbDoiTac.DataSource = table;
            cbbDoiTac.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            form.id_nhanvien= this.id_nhanvien;
            form.Show();
            this.Hide();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Form19 form = new Form19();
            form.id_nhanvien = this.id_nhanvien;
            form.Show();
            this.Close();
        }
    }
}
