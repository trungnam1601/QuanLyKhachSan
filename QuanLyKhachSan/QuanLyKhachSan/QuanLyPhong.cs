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
            command.CommandText = "select P.MALOAIPHONG, LP.TENLOAIPHONG, P.SOPHONG, LP.SONGUOITOIDA,LP.GIA,P.TINHTRANG  from PHONG AS P,LOAIPHONG AS LP where P.MALOAIPHONG = LP.MALOAIPHONG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgPhong.DataSource = table;

            UpdateTENLOAIPHONG();
            UpdateGIA();
            UpdateSONGUOI();
          
        }

        private void UpdateGIA()
        {
            cbxGia.Items.Clear();
            command.CommandText = "SELECT * FROM LOAIPHONG ORDER BY GIA";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxGia.Items.Add(sqlReader["GIA"].ToString());
            }
            sqlReader.Close();
        }

        private void UpdateTENLOAIPHONG()
        {
            cbxTenLoaiPhong.Items.Clear();
            command.CommandText = "SELECT * FROM LOAIPHONG order by TENLOAIPHONG";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxTenLoaiPhong.Items.Add(sqlReader["TENLOAIPHONG"].ToString());
            }
            sqlReader.Close();
        }

        private void UpdateSONGUOI()
        {
            cbxSonguoi.Items.Clear();
            command.CommandText = "SELECT * FROM LOAIPHONG order by SONGUOITOIDA ASC";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxSonguoi.Items.Add(sqlReader["SONGUOITOIDA"].ToString());
            }
            sqlReader.Close();
        }
        public QuanLyPhong()
        {
            InitializeComponent();
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helper.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgPhong.CurrentRow.Index;
            txtMaLP.Text = dtgPhong.Rows[i].Cells[0].Value.ToString();
            cbxTenLoaiPhong.Text= dtgPhong.Rows[i].Cells[1].Value.ToString();
            txtSoPhong.Text= dtgPhong.Rows[i].Cells[2].Value.ToString();
            cbxSonguoi.Text= dtgPhong.Rows[i].Cells[3].Value.ToString();
            cbxGia.Text= dtgPhong.Rows[i].Cells[4].Value.ToString();
            cbxTinhTrang.Text= dtgPhong.Rows[i].Cells[5].Value.ToString();
        }

        
    }
}
