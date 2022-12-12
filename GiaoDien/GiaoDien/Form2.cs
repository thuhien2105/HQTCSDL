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
    public partial class Form2 : Form
    {
        SqlConnection _connection = null;
        SqlCommand _command = null;
        String _connectionString = "";
        public Form2()
        {
            InitializeComponent();
            _connectionString = @"Data Source=MSI\HIENTHU;Initial Catalog=DOAN;Integrated Security=True";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnTatCaCuaHang_click(object sender, EventArgs e)
        {
          
        }
    }
}
