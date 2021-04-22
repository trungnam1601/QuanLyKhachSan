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

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtDonGia.Text = "";
        }


        private void btThem_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.define.dataSource);
            string id = txtMaDV.Text;
            connection.Open();


            string sql = "select * from DICHVU where MADV = '" + txtMaDV.Text + "'";

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
                command.CommandText = "Insert into DICHVU values('" + txtMaDV.Text + "', N'" + txtTenDV.Text + "','" + txtDonGia.Text + "')";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void BtSua_Click_1(object sender, EventArgs e)
        {
            txtMaDV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update DICHVU set MaDV = N'" + txtMaDV.Text + "', N'" + txtTenDV.Text + "','" + txtDonGia.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update CHITIETPHIEUDV set MaDV = null where MaDV = '" + txtMaDV.Text + "'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "delete from DICHVU where MaDV ='" + txtMaDV.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
