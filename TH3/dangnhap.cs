using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap1
{
    public partial class frmDangNhap : Form
    {
        DataHelper dataHelper = new DataHelper();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = dangnhap.Text.Trim();
            string matKhau = mk.Text.Trim();

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản và mật khẩu.", "Thông báo");
                dangnhap.Focus();
                return;
            }

            try
            {
                dataHelper.InitializeConnection("Server=LAPTOP-899I2AVH\\SQLEXPRESS;Database=QuanLyThuVien;Integrated Security=True");

                string query = $"SELECT * FROM nhanvien WHERE tendangnhap = '{taiKhoan}' AND matkhau = '{matKhau}'";

                SqlDataReader reader = dataHelper.ExecuteReader(query);

                if (reader != null && reader.Read()) 
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                    this.Hide();
                    frmQuanLyNhanVien frmQLNV = new frmQuanLyNhanVien();
                    frmQLNV.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Thông báo");
                    dangnhap.Focus();
                }

                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi");
            }
            finally
            {
                dataHelper.CloseConnection();
            }
        }
    }
}
