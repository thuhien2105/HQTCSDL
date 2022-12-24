using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien
{
    public partial class Form12 : Form
    {
        public String id_doitac;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form12()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            String email = this.textBox2.Text;
            String dc = this.textBox3.Text;
            String sdt = this.textBox4.Text;
            String tnh = this.textBox5.Text;
            String stk = this.textBox6.Text;

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec proc_updatethongtindoitac  '"+ id_doitac+"','" + email + "','" + dc + "','" + sdt + "', '" + tnh + "','" + stk + "'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
            if (n > 0)
                MessageBox.Show("Update successfully !!!");
            else
                MessageBox.Show("Error !!!");

            _connection.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            lblTenDoiTac.Text = id_doitac;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.id_doitac = id_doitac;
            f.Show();
            this.Close();
        }
    }
}
