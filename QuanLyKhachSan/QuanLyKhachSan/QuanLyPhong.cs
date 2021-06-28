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
    public partial class QuanLyPhong : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select P.MALOAIPHONG, LP.TENLOAIPHONG, P.SOPHONG, LP.SONGUOITOIDA,LP.GIA,P.TINHTRANG  from PHONG AS P,LOAIPHONG AS LP where P.MALOAIPHONG = LP.MALOAIPHONG ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgPhong.DataSource = table;

            txtTenLP.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtSoNguoi.ReadOnly = true;
            
        }
        
       
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i;
            i = dtgPhong.CurrentRow.Index;
            cbxMaLP.Text = dtgPhong.Rows[i].Cells[0].Value.ToString();
            txtTenLP.Text= dtgPhong.Rows[i].Cells[1].Value.ToString();
            txtSoPhong.Text= dtgPhong.Rows[i].Cells[2].Value.ToString();
            txtSoNguoi.Text= dtgPhong.Rows[i].Cells[3].Value.ToString();
            txtGia.Text= dtgPhong.Rows[i].Cells[4].Value.ToString();
            cbxTinhTrang.Text= dtgPhong.Rows[i].Cells[5].Value.ToString();
        }

        private void cbxMaLP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maloaiphong = cbxMaLP.Text;
            command.CommandText = "SELECT TENLOAIPHONG, GIA, SONGUOITOIDA FROM LOAIPHONG WHERE MALOAIPHONG = '" + maloaiphong + "'";
            sqlReader = command.ExecuteReader();
            if (sqlReader.HasRows)
            {
                if (sqlReader.Read())
                {
                    txtTenLP.Text = sqlReader["TENLOAIPHONG"].ToString();
                    txtSoNguoi.Text = sqlReader["SONGUOITOIDA"].ToString();
                    txtGia.Text = sqlReader["GIA"].ToString();
                }
                sqlReader.Close();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbxMaLP.Text = "";
            txtSoPhong.Text = "";
            cbxTinhTrang.Text = "";
            txtTenLP.Text = "";
            txtGia.Text = "";
            txtSoNguoi.Text = "";
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();

            if(cbxMaLP.Text != null )
             
                command = connection.CreateCommand();
                command.CommandText = "Insert into PHONG values('" + cbxMaLP.Text + "','" + txtSoPhong.Text + "', '" + cbxTinhTrang.Text + "'  )";
                command.ExecuteNonQuery();
                loadData();   
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
                 command = connection.CreateCommand();
                 command.CommandText = "update PHONG set MALOAIPHONG = '" + cbxMaLP.Text + "', SOPHONG= '" + txtSoPhong.Text + "', TINHTRANG= N'" + cbxTinhTrang.Text + "' where SOPHONG ='"+ txtSoPhong.Text + "' ";
                 command.ExecuteNonQuery();
                 loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
            command.CommandText = "update CHITIETPHIEUDAT set SOPHONG = null where SOPHONG = '" + txtSoPhong.Text + "'";
            command.ExecuteNonQuery();

            command = connection.CreateCommand();
            command.CommandText = "delete from PHONG where SOPHONG ='" + txtSoPhong.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
