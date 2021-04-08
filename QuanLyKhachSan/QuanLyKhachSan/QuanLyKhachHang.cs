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
    public partial class QuanLyKhachHang : Form
    {

        SqlConnection connection;
        SqlCommand command;

        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KHACHHANG ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgQuanLyKhachHang.DataSource = table;

        }
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helper.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgQuanLyKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgQuanLyKhachHang.CurrentRow.Index;
            txtMaKH.Text= dtgQuanLyKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dtgQuanLyKhachHang.Rows[i].Cells[1].Value.ToString();
            cbxGioiTinh.Text = dtgQuanLyKhachHang.Rows[i].Cells[2].Value.ToString();
            dateNgaySinh.Text = dtgQuanLyKhachHang.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dtgQuanLyKhachHang.Rows[i].Cells[4].Value.ToString();
            txtSCMND.Text = dtgQuanLyKhachHang.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Text = dtgQuanLyKhachHang.Rows[i].Cells[6].Value.ToString();
            txtQuocTich.Text = dtgQuanLyKhachHang.Rows[i].Cells[7].Value.ToString();
        }
    }
}
