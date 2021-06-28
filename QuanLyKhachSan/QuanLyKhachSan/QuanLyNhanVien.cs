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
            connection = new SqlConnection(Helpers.define.dataSource);
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
            txtTimKiem.Text = "";

            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            string id = txtMaNV.Text;
            connection.Open();


            string sql = "select * from NHANVIEN where MANV = '" + txtMaNV.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {

                MessageBox.Show(" Trùng mã! Mời Nhập lại");
            }
            else
            {
                dta.Close();
                command = connection.CreateCommand();
                command.CommandText = "Insert into NHANVIEN values('" + txtMaNV.Text + "', N'" + txtTenNV.Text + "','" + dateNgaySinh.Text + "', '" + txtSDT.Text + "', N'" + txtDiaChi.Text + "', '" + cbxGioiTinh.Text + "', '" + txtLuong.Text + "'  )";
                command.ExecuteNonQuery();
                loadData();
            }
        }


        private void BtSua_Click_1(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update NHANVIEN set MaNV = '" + txtMaNV.Text + "', TenNV= N'" + txtTenNV.Text + "', NS ='" + dateNgaySinh.Text + "', SDT= '" + txtSDT.Text + "', DIACHI= N'" + txtDiaChi.Text + "', GIOITINH= '" + cbxGioiTinh.Text + "', LUONG= '" + txtLuong.Text + "' where MaNV = '" + txtMaNV.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HOADON set MaNV = null where MaNV = '" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "update PHIEUDATPHONG set MaNV = null where MaNV = '" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "delete from NHANVIEN where MaNV ='" + txtMaNV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();
            if (txtTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                txtTimKiem.Focus();
            }
            else
            {

                string sql = "select * from NHANVIEN where MANV LIKE '%" + txtTimKiem.Text + "%' or TENNV Like N'%" + txtTimKiem.Text + "%' or NS LIKE '%" + txtTimKiem.Text + "%' or SDT LIKE '%" + txtTimKiem.Text + "%' or DIACHI LIKE '%" + txtTimKiem.Text + "%' or GIOITINH LIKE '%" + txtTimKiem.Text + "%' or LUONG LIKE '%" + txtTimKiem.Text + "%'";

                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    dta.Close();
                    command = connection.CreateCommand();
                    command.CommandText = "select * from NHANVIEN where MANV LIKE '%" + txtTimKiem.Text + "%' or TENNV Like N'%" + txtTimKiem.Text + "%' or NS LIKE '%" + txtTimKiem.Text + "%' or SDT LIKE '%" + txtTimKiem.Text + "%' or DIACHI LIKE '%" + txtTimKiem.Text + "%' or GIOITINH LIKE '%" + txtTimKiem.Text + "%' or LUONG LIKE '%" + txtTimKiem.Text + "%'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dtgQuanLyNhanVien.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Không có thông tin cần tìm!");
                }
            }
        }

       
    }
}
