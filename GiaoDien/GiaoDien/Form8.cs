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
    public partial class Form8 : Form
    {
        public String monan;
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form8()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from [THUC DON] join [DOI TAC] on [THUC DON].[Ma doi tac]= [DOI TAC].[Ma doi tac] and [THUC DON].[Ten mon] like N'"+monan+"'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbTimKiem.ValueMember = "Ma doi tac";
            cbbTimKiem.DisplayMember = "Ten quan";
            cbbTimKiem.DataSource = table;
            cbbTimKiem.SelectedIndex = -1;


            //setGridViewEditable(false);

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            DataRowView row = (DataRowView)cbbTimKiem.SelectedItem;
            form4.tenquan = (String)row.Row["Ten quan"];
            form4.id_doitac = (String)row.Row["Ma doi tac"];
            form4.id_khachhang = id_khachhang;
            form4.Show();
            this.Hide();
        }
    }
}
