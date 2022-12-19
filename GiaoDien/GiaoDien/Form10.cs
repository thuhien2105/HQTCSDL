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

    public partial class Form10 : Form
    {
        public String id_taixe;
        public String id_khuvuc;
        public String id_donhang;
        public String id_khachhang;
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public Form10()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
            dataGridView1.AutoGenerateColumns = false;
        }

        private void Form10_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dOANDataSet.DON_HANG' table. You can move, or remove it, as needed.
            //lay khu vuc cua tac xe
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "select * from [TAI XE] where MaTX='" + id_taixe + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                id_khuvuc = reader["id_khuvuc"].ToString();
            }
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dsdonhang '" + id_khuvuc+"'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDSDonHang.ValueMember = "MaKH";
            cbbDSDonHang.DisplayMember = "id_donhang";
            cbbDSDonHang.DataSource = table;
            cbbDSDonHang.SelectedIndex = -1;

            dataGridView1.DataSource = table;
        }

        private void btnChonDonHang_Click(object sender, EventArgs e)
        {
            Form10_1 form10_1 = new Form10_1();
            DataRowView row = (DataRowView)cbbDSDonHang.SelectedItem;
            id_donhang= (String)row.Row["id_donhang"];
            form10_1.id_donhang = (String)row.Row["id_donhang"];
            form10_1.id_khachhang = (String)row.Row["MaKH"];
            form10_1.id_taixe = id_taixe;
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec taixe_nhandon '"+id_donhang+"','"+id_taixe+"'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();


            form10_1.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10_1 form10_1 = new Form10_1();

            form10_1.id_taixe = id_taixe;

            form10_1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10_2 form10_2= new Form10_2();
            form10_2.id_taixe=id_taixe;
            form10_2.Show();
            this.Close();
        }
    }
}
