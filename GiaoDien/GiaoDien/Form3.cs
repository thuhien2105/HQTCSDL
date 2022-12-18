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
    public partial class Form3 : Form
    {
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form3()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
            dataGridView1.AutoGenerateColumns = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [DOI TAC]", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbTimKiemCuaHang.ValueMember = "Ma doi tac";
            cbbTimKiemCuaHang.DisplayMember = "Ten quan";
            cbbTimKiemCuaHang.DataSource = table;
            cbbTimKiemCuaHang.SelectedIndex = -1;


            //setGridViewEditable(false);

            dataGridView1.DataSource = table;

        }

        private void btnTimKiemCuahang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            DataRowView row = (DataRowView)cbbTimKiemCuaHang.SelectedItem;
            form4.tenquan = (String)row.Row["Ten quan"];
            form4.id_doitac = (String)row.Row["Ma doi tac"];
            form4.id_khachhang = id_khachhang;
            form4.Show();

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
