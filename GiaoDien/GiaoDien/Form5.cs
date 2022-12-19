using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form5 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String tongdonhang;
        public String phivanchuyen;
        public string id_khachhang;
        public Form5()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }
        public string id_donhang;
        private void Form5_Load(object sender, EventArgs e)
        {
            lblTongDonHang.Text= tongdonhang;
            lblPhiVanChuyen.Text = phivanchuyen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String diachi;
            diachi = txtDiaChi.Text;
            string selectedItems = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    selectedItems = checkedListBox1.Items[i].ToString();
            }
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            String sql = "exec hoantatdonhang '" + id_donhang + "',N'" + selectedItems + "',N'"+diachi+"'";
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Hide();    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec huydonhang '" + id_donhang + "'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            SqlDataReader reader = _command.ExecuteReader();

            Form2 form2 = new Form2();
            form2.id_khachhang = id_khachhang;
            form2.Show();
            this.Close();
        }
    }
}
