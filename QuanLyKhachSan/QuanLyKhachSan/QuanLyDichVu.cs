using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan
{

    public partial class QuanLyDichVu : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from DICHVU ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgQuanLyDichVu.DataSource = table;
            

        }
        

        public QuanLyDichVu()
        {
            InitializeComponent();
        }

        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helper.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgQuanLyDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgQuanLyDichVu.CurrentRow.Index;
            txtMaDV.Text = dtgQuanLyDichVu.Rows[i].Cells[0].Value.ToString();
            txtTenDV.Text = dtgQuanLyDichVu.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dtgQuanLyDichVu.Rows[i].Cells[2].Value.ToString();
        }
    }
}
