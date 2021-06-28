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
    public partial class ManHinhChinh : Form
    {

        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
    

        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUDATPHONG  ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgPhieudatphong.DataSource = table;

            UpdateMANV();
            UpdateMAKH();
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

        private void UpdateMAKH()
        {
            cbxMaKH.Items.Clear();
            command.CommandText = "SELECT * FROM KHACHHANG";
            sqlReader = command.ExecuteReader();
            while (sqlReader.Read())
            {
                cbxMaKH.Items.Add(sqlReader["MAKH"].ToString());
            }
            sqlReader.Close();
        }
        public ManHinhChinh()
        {
            InitializeComponent();
            Closed += OnClose;
            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var helperDialog = new Helpers.Helper();
                helperDialog.ShowDialog();
            }
        }

        private void OnClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchinh.Controls.Add(childForm);
            panelchinh.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // lblTitleChildForm.Text = childForm.Text;
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhong());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDichVu());
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Helpers.define.dataSource);
            connection.Open();
            loadData();
        }

        private void dtgPhieudatphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtgPhieudatphong.CurrentRow.Index;
            txtMaPhieuDat.Text = dtgPhieudatphong.Rows[i].Cells[0].Value.ToString();
            datengaylap.Text= dtgPhieudatphong.Rows[i].Cells[1].Value.ToString();
            datengayden.Text = dtgPhieudatphong.Rows[i].Cells[2].Value.ToString();
            cbxMaNV.Text = dtgPhieudatphong.Rows[i].Cells[3].Value.ToString();
            cbxMaKH.Text = dtgPhieudatphong.Rows[i].Cells[4].Value.ToString();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
           
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtMaPhieuDat.Text = "";
            datengaylap.Text = "";
            datengayden.Text = "";
            cbxMaNV.Text = "";
            cbxMaKH.Text = "";
            txtTimKiem.Text = "";
            loadData();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            new Helpers.Helper().ShowDialog();
        }

        private void QuanLyVatTu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VatDung());
        }

        private void btThem_Click(object sender, EventArgs e)
        {
             SqlConnection connection = new SqlConnection(Helpers.define.dataSource);
            string id = txtMaPhieuDat.Text;
            connection.Open();


            string sql = "select * from PHIEUDATPHONG where MAPHIEUDATPHONG = '" + txtMaPhieuDat.Text + "'";

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
                command.CommandText = "Insert into PHIEUDATPHONG values('" + txtMaPhieuDat.Text + "', '" + datengaylap.Text + "','" + datengayden.Text + "', '" + cbxMaNV.Text + "', '" + cbxMaKH.Text + "' )";
                command.ExecuteNonQuery();
                loadData();
            }

        }

        private void BtSua_Click(object sender, EventArgs e)
        {
           // txtMaPhieuDat.ReadOnly = true;
            command = connection.CreateCommand();
            command.CommandText = "update PHIEUDATPHONG set MAPHIEUDATPHONG = '" + txtMaPhieuDat.Text + "', NGAYLAPPHIEU= '" + datengaylap.Text + "', NGAYDEN ='" + datengayden.Text + "', MANV = '" + cbxMaNV.Text + "', MAKH = '" + cbxMaKH.Text + "' where MAPHIEUDATPHONG = '" + txtMaPhieuDat.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from PHIEUDATPHONG where MAPHIEUDATPHONG ='" + txtMaPhieuDat.Text + "'";
            command.ExecuteNonQuery();
            loadData();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThanhToan());
        }

        private void btTimKiem_Click(object sender, EventArgs e)
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

                string sql = "select * from PHIEUDATPHONG where MAPHIEUDATPHONG LIKE '%" + txtTimKiem.Text + "%' or NGAYLAPPHIEU Like N'%" + txtTimKiem.Text + "%' or NGAYDEN LIKE '%" + txtTimKiem.Text + "%' or MANV LIKE '%"+txtTimKiem.Text+ "%' or MAKH LIKE '%" + txtTimKiem.Text + "%'";

                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dta = cmd.ExecuteReader();

                if (dta.Read() == true)
                {
                    dta.Close();
                    command = connection.CreateCommand();
                    command.CommandText = "select * from PHIEUDATPHONG where MAPHIEUDATPHONG LIKE '%" + txtTimKiem.Text + "%' or NGAYLAPPHIEU Like N'%" + txtTimKiem.Text + "%' or NGAYDEN LIKE '%" + txtTimKiem.Text + "%' or MANV LIKE '%" + txtTimKiem.Text + "%' or MAKH LIKE '%" + txtTimKiem.Text + "%'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dtgPhieudatphong.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Không có thông tin cần tìm!");
                }
            }
        }
    }
}
