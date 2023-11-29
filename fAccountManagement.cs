using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBTLQlyTV
{
    public partial class fAccountManagement : Form
    {
        string oldusername;
        public fAccountManagement()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            fMain m = new fMain();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        //Hiển thị thông tin tài khoản
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAccount();
            dtgvAccountList.DataSource = table;
        }
        private void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtDisplayName.Clear();
            chbAdmin.Checked = false;
        }



        private void fAccountManagement_Load(object sender, EventArgs e)
        {
            load();
        }

        //Thêm tài khoản
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string displayname = txtDisplayName.Text;
                string password = txtPassword.Text;
                string type = "Thủ thư";
                if (chbAdmin.Checked == true)
                {
                    type = "Quản lý";
                }
                DataProvider provider = new DataProvider();
                provider.addAccount(username, displayname, password, type);
                MessageBox.Show("Thêm thành công! ", "notice");
                load();
                Clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được tài khoản", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Xóa tài khoản
        private void bntDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản " + oldusername + " không?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string name = txtUsername.Text;
                    DataProvider provider = new DataProvider();
                    provider.delAccount(name);
                    MessageBox.Show("Xóa thành công tài khoản " + name, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    Clear();
                }
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newusername = txtUsername.Text;
            string newdisplayname = txtDisplayName.Text;
            string newpassword = txtPassword.Text;
            string type = "Thủ thư";
            if (chbAdmin.Checked)
            {
                type = "Quản lý";
            }
            try
            {

                DataProvider provider = new DataProvider();
                provider.editAccount(newusername, newdisplayname, newpassword, type, oldusername);
                MessageBox.Show("Chỉnh sửa thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                Clear();
            }
            catch
            {
                MessageBox.Show("Không chỉnh sửa được ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvAccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvAccountList.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[0].Value.ToString();
                oldusername = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "Quản lý")
                {
                    chbAdmin.Checked = true;
                }
                else if (row.Cells[3].Value.ToString() == "Thủ thư")
                {
                    chbAdmin.Checked = false;
                }
            }
        }
        
    }
}
