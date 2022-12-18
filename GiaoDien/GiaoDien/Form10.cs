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
            id_khuvuc = reader["id_khuvuc"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("exec dsdonhang '"+id_khuvuc+"'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbDSDonHang.ValueMember = "id_donhang";
            cbbDSDonHang.DisplayMember = "id_donhang";
            cbbDSDonHang.DataSource = table;
            cbbDSDonHang.SelectedIndex = -1;


            //setGridViewEditable(false);

            dataGridView1.DataSource = table;
        }
    }
}
