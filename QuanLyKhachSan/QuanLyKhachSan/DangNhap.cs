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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Helper.define.dataSource);

            try
            {
                connection.Open();

                string taiKhoan = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                string sql = "select * from DANGNHAP where Taikhoan = '" + taiKhoan + "' and Matkhau = '" + matKhau + "'";

                SqlCommand cmd = new SqlCommand(sql, connection);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    this.Hide();
                    ManHinhChinh manHinhChinh = new ManHinhChinh();
                    manHinhChinh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
