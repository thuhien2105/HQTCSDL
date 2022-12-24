using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class Form11 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String connectionString = "";
        public String id_doitac;
        public String tenquan;
        public String diachi;
        public String email;
        public String ratetb;
        public String tennganhang;
        public String stk;
        public String slchinhanh;
        public String sdt;
        public Form11()
        {
            InitializeComponent();
            connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f=new Form12();
            f.id_doitac=id_doitac;
            f.Show();
            this.Hide();

        }

        private void quảnLíDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 f=new Form13();
            f.id_doitac = id_doitac;
            f.Show();
            this.Hide();
        }

        private void quảnLíToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form14 f=new Form14();
            f.id_doitac = id_doitac;
            f.Show();
            this.Hide();
        }

        private void quảnLíThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 f=new Form15();
            f.id_doitac = id_doitac;
            f.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //Bước 1: Tạo đối tượng kết nối để CSDL & mở kết nối
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            //Bước 2: Xây dựng câu lệnh SQL để thực hiện chức năng mong muốn
            String sql = "exec xemthongtindoitac '" + id_doitac+"'";
            //Bước 3: Tạo đối tượng thực thi câu lệnh
            _command = new SqlCommand(sql, _connection);
            _command.Connection = _connection;
            //Bước 4: Thực thi câu SQL và lấy kết quả trả về
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                tenquan=reader["Ten quan"].ToString();
               // label9.Text = tenquan;
                diachi = reader["Thanh pho/Quan"].ToString();
                sdt= reader["So dien thoai"].ToString();
                email= reader["Email"].ToString();
                ratetb = reader["ratetb"].ToString();
                tennganhang = reader["Ten ngan hang"].ToString();
                stk = reader["So tai khoan"].ToString();
                slchinhanh = reader["So luong chi nhanh"].ToString();
            }
            lbltenquan.Text = tenquan;
            lbldiachi.Text = diachi;
            lblsdt.Text = sdt;
            lblemail.Text = email;
            lblrate.Text = ratetb;
            lbltennganhang.Text = tennganhang;
            lblstk.Text = stk;
            lblsochinhanh.Text = slchinhanh;
        }


    }
}
