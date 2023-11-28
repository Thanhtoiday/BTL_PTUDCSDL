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

namespace appBTLQlyTV
{
    public partial class fLogin : Form
    {
        string usernamename;
        string password;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            usernamename = txtUsername.Text;
            password = txtPassword.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QUANLYTHUvIEN;Integrated Security=True"))
                {
                    conn.Open();
                    String sql = "select count(*) from ACCOUNT where USERNAME=@username and PASSWORD =@password";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@username";
                    param.Value = usernamename;
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@password";
                    param1.Value = password;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(param1);
                    var flag = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (flag != 0)
                    {
                        fMain main = new fMain();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thoát chương trình", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
