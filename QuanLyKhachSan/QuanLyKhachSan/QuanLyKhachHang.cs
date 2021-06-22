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
            connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgQuanLyKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgQuanLyKhachHang.CurrentRow.Index;
            txtMaKH.Text = dtgQuanLyKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dtgQuanLyKhachHang.Rows[i].Cells[1].Value.ToString();
            cbxGioiTinh.Text = dtgQuanLyKhachHang.Rows[i].Cells[2].Value.ToString();
            dateNgaySinh.Text = dtgQuanLyKhachHang.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dtgQuanLyKhachHang.Rows[i].Cells[4].Value.ToString();
            txtSCMND.Text = dtgQuanLyKhachHang.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Text = dtgQuanLyKhachHang.Rows[i].Cells[6].Value.ToString();
            txtQuocTich.Text = dtgQuanLyKhachHang.Rows[i].Cells[7].Value.ToString();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cbxGioiTinh.Text = "";
            dateNgaySinh.Text = "";
            txtSDT.Text = "";
            txtSCMND.Text = "";
            txtDiaChi.Text = "";
            txtQuocTich.Text = "";
        }



        private void btThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            string id = txtMaKH.Text;
            connection.Open();


            string sql = "select * from KHACHHANG where MAKH = '" + txtMaKH.Text + "'";

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
                command.CommandText = "Insert into KHACHHANG values('" + txtMaKH.Text + "', N'" + txtTenKH.Text + "','" + cbxGioiTinh.Text + "', '" + dateNgaySinh.Text + "', '" + txtSDT.Text + "','" + txtSCMND.Text + "', N'" + txtDiaChi.Text + "', '" + txtQuocTich.Text + "'  )";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            // txtMaKH.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update KHACHHANG set MaKH = '" + txtMaKH.Text + "', TENKH= N'" + txtTenKH.Text + "', GIOITINH='" + cbxGioiTinh.Text + "', NS= '" + dateNgaySinh.Text + "', SDT= '" + txtSDT.Text + "', SOCMND='" + txtSCMND.Text + "', DIACHI= N'" + txtDiaChi.Text + "', QUOCTICH= '" + txtQuocTich.Text + "'  WHERE MaKH = '" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update PHIEUDATPHONG set MaKH = null where MaKH = '" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "delete from KHACHHANG where MaKH ='" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
