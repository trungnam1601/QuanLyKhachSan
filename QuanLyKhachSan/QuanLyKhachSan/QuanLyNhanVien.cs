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
    public partial class QuanLyNhanVien : Form
    {

        SqlConnection connection;
        SqlCommand command;

        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgQuanLyNhanVien.DataSource = table;

        }

        
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helper.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgQuanLyNhanVien.CurrentRow.Index;
            txtMaNV.Text = dtgQuanLyNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dtgQuanLyNhanVien.Rows[i].Cells[1].Value.ToString();
            dateNgaySinh.Text = dtgQuanLyNhanVien.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dtgQuanLyNhanVien.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dtgQuanLyNhanVien.Rows[i].Cells[4].Value.ToString();
            cbxGioiTinh.Text = dtgQuanLyNhanVien.Rows[i].Cells[5].Value.ToString();
            txtLuong.Text = dtgQuanLyNhanVien.Rows[i].Cells[6].Value.ToString();
          
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dateNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            cbxGioiTinh.Text = "";
            txtLuong.Text = "";
        }
    }
}
