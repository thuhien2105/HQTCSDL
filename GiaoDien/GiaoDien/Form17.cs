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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GiaoDien
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
            dataGridView1.AutoGenerateColumns = false;
        }
        public String id_hopdong;
        public String id_nhanvien;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOANDataSet5.dshopdong' table. You can move, or remove it, as needed.
            this.dshopdongTableAdapter.Fill(this.dOANDataSet5.dshopdong);
            this.dshopdongTableAdapter.Fill(this.dOANDataSet5.dshopdong);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dshopdong_chuaduyet", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDuyetHopDong.ValueMember = "id_hopdong";
            cbbDuyetHopDong.DisplayMember = "Ten quan";
            cbbDuyetHopDong.DataSource = table;
            cbbDuyetHopDong.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbbDuyetHopDong.SelectedItem;
            id_hopdong = (String)row.Row["id_hopdong"];

            _connection = new SqlConnection(connectionString);
            _connection.Open();

            String sql = "exec duyethopdoong '"+id_nhanvien+"','"+id_hopdong+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            int n = _command.ExecuteNonQuery();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Form18 form = new Form18(); 
            form.id_nhanvien = id_nhanvien;
            form.Show();
            this.Close();
        }
    }
}
