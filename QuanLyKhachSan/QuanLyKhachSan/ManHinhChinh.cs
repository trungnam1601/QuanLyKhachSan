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

        SqlDataAdapter adapter = new SqlDataAdapter();

        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select P.MAPHIEUDATPHONG,C.SOPHONG,P.NGAYLAPPHIEU,P.NGAYDEN,C.NGAYTRAPHONG,P.MAKH,P.MANV from PHIEUDATPHONG AS P, CHITIETPHIEUDAT AS C ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgPhieudatphong.DataSource = table;

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
            txtSophong.Text= dtgPhieudatphong.Rows[i].Cells[1].Value.ToString();
            dateNgayLap.Text= dtgPhieudatphong.Rows[i].Cells[2].Value.ToString();
            dateNgayDen.Text= dtgPhieudatphong.Rows[i].Cells[3].Value.ToString();
            datengaytra.Text = dtgPhieudatphong.Rows[i].Cells[4].Value.ToString();
            txtMaKH.Text = dtgPhieudatphong.Rows[i].Cells[5].Value.ToString();
            txtMaNV.Text = dtgPhieudatphong.Rows[i].Cells[6].Value.ToString();
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
            dateNgayLap.Text = "";
            txtSophong.Text = "";
            datengaytra.Text = "";
            dateNgayDen.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            new Helpers.Helper().ShowDialog();
        }
    }
}
