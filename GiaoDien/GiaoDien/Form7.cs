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
    public partial class Form7 : Form
    {
        public String id_khachhang;
        public String id_donhang;
        public String rate;
        public String comment;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form7()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lblComment.Hide();
            txtComment.Hide();
            lblRate.Hide();
            numRate.Hide();
            btnDongY.Hide();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec donhang_thanhcong '" + id_khachhang + "'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbMaDonHang.DataSource = table;
            cbbMaDonHang.ValueMember = "id_donhang";
            cbbMaDonHang.DisplayMember = "id_donhang";
            cbbMaDonHang.SelectedIndex = -1;

        }

       

        private void btnChon_Click(object sender, EventArgs e)
        {
            lblComment.Show();
            txtComment.Show();
            lblRate.Show();
            numRate.Show();
            btnDongY.Show();
            DataRowView row = (DataRowView)cbbMaDonHang.SelectedItem;
            id_donhang = (String)row.Row["id_donhang"];
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            comment=txtComment.Text;
            rate = numRate.Value.ToString();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec danhgiadonhang '" + id_donhang + "','"+id_khachhang+"',N'"+comment+"','"+rate+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            Form2 form2 = new Form2();
            form2.Show();
            this.Close();

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
