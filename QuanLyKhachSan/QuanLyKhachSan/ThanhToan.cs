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
    public partial class ThanhToan : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HOADON ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgThanhToan.DataSource = table;

            UpdateMANV();
            UpdateMaPDP();
        }

        private void UpdateMANV()
        {
            cbxMaNV.Items.Clear();
            command.CommandText = "SELECT * FROM NHANVIEN";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxMaNV.Items.Add(sqlReader["MANV"].ToString());
            }
            sqlReader.Close();
        }
        private void UpdateMaPDP()
        {
            cbxMaPDP.Items.Clear();
            command.CommandText = "SELECT * FROM PHIEUDATPHONG";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxMaPDP.Items.Add(sqlReader["MAPHIEUDATPHONG"].ToString());
            }
            sqlReader.Close();
        }
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgThanhToan.CurrentRow.Index;
            txtMaHD.Text = dtgThanhToan.Rows[i].Cells[0].Value.ToString();
            dateNgayLap.Text = dtgThanhToan.Rows[i].Cells[1].Value.ToString();
            txtTongtien.Text = dtgThanhToan.Rows[i].Cells[2].Value.ToString();
            cbxMaNV.Text = dtgThanhToan.Rows[i].Cells[3].Value.ToString();
            cbxMaPDP.Text = dtgThanhToan.Rows[i].Cells[4].Value.ToString();
           
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            dateNgayLap.Text = "";
            txtTongtien.Text = "";
            cbxMaNV.Text = "";
            cbxMaPDP.Text = "";
            txtTimKiem.Text = "";
            loadData();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            string id = txtMaHD.Text;
            connection.Open();


            string sql = "select * from HOADON where MAHD = '" + txtMaHD.Text + "'";

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
                command.CommandText = "Insert into HOADON values('" + txtMaHD.Text + "', '" + dateNgayLap.Text + "','" + txtTongtien.Text + "', '" + cbxMaNV.Text + "', '" + cbxMaPDP.Text + "' )";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            txtMaHD.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update HOADON set MAHD = '" + txtMaHD.Text + "', NGAYLAP= N'" + dateNgayLap.Text + "', TONGTIEN ='" + txtTongtien.Text + "', MANV= '" + cbxMaNV.Text + "', MAPHIEUDATPHONG= '" + cbxMaPDP.Text + "' where MAHD = '" + txtMaHD.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            command.CommandText = "delete from HOADON where MAHD ='" + txtMaHD.Text + "'";
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

                string sql = "select * from HOADON where MAHD LIKE '%" + txtTimKiem.Text + "%' or NGAYLAP Like N'%" + txtTimKiem.Text + "%' or TONGTIEN LIKE '%" + txtTimKiem.Text + "%' or MANV LIKE '%" + txtTimKiem.Text + "%' or MAPHIEUDATPHONG LIKE '%" + txtTimKiem.Text + "%'";

                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    dta.Close();
                    command = connection.CreateCommand();
                    command.CommandText = "select * from HOADON where MAHD LIKE '%" + txtTimKiem.Text + "%' or NGAYLAP Like N'%" + txtTimKiem.Text + "%' or TONGTIEN LIKE '%" + txtTimKiem.Text + "%' or MANV LIKE '%" + txtTimKiem.Text + "%' or MAPHIEUDATPHONG LIKE '%" + txtTimKiem.Text + "%'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dtgThanhToan.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Không có thông tin cần tìm!");
                }
            }
        }
    }
}
