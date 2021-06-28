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
    public partial class VatDung : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from VATTU  ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgVattu.DataSource = table;
           // select V.MAVT, V.TENVT, V.TINHTRANG, V.SOLUONG, V.GIA, LP.MALOAIPHONG from VATTU AS V,LOAIPHONG AS LP where V.MALOAIPHONG = LP.MALOAIPHONG



        }
        public VatDung()
        {
            InitializeComponent();
        }

        private void dtgVattu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgVattu.CurrentRow.Index;
            txtMaVT.Text = dtgVattu.Rows[i].Cells[0].Value.ToString();
            txtTenVT.Text = dtgVattu.Rows[i].Cells[1].Value.ToString();
            cbxTinhTrang.Text = dtgVattu.Rows[i].Cells[2].Value.ToString();
            txtSoluong.Text = dtgVattu.Rows[i].Cells[3].Value.ToString();
            txtGia.Text = dtgVattu.Rows[i].Cells[4].Value.ToString();
            cbxMaLP.Text = dtgVattu.Rows[i].Cells[5].Value.ToString();
        }

        private void VatDung_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            string id = txtMaVT.Text;
            connection.Open();


            string sql = "select * from VATTU where  MAVT = '" + txtMaVT.Text + "'";

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
                command.CommandText = "Insert into VATTU values('" + txtMaVT.Text + "', N'" + txtTenVT.Text + "',N'" + cbxTinhTrang.Text + "', '" + txtSoluong.Text + "', '" + txtGia.Text + "', '" + cbxMaLP.Text + "'  )";
                command.ExecuteNonQuery();
                loadData();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaVT.Text = "";
            txtTenVT.Text = "";
            cbxTinhTrang.Text = "";
            txtSoluong.Text = "";
            txtGia.Text = "";
            cbxMaLP.Text = "";
            loadData();
            
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            //txtMaNV.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update VATTU set MaVT = '" + txtMaVT.Text + "', TenVT= N'" + txtTenVT.Text + "', TINHTRANG =N'" + cbxTinhTrang.Text + "', SOLUONG= '" + txtSoluong.Text + "', GIA= '" + txtGia.Text + "', MALOAIPHONG= '" + cbxMaLP.Text + "' where MaVT = '" + txtMaVT.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            

            command = connection.CreateCommand();
            command.CommandText = "delete from VATTU where MaVT ='" + txtMaVT.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
