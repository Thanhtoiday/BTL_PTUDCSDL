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
    public partial class fCustomerManagerment : Form
    {
        string oldname;
        public fCustomerManagerment()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadCustomer();
            dtgvCustomerList.DataSource = table;

        }

        private void loadSeacrh(string name)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchCustomer(name);
            dtgvCustomerList.DataSource = table;
        }

        private void CustomerManagerment_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            fMain m = new fMain();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }
        private void Clear()
        {
            txtNAME.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNAME.Text;
                string birth = dtpBirthDate.Text;
                string address = txtAddress.Text;
                string phonenumber = txtPhoneNumber.Text;
                DataProvider provider = new DataProvider();
                provider.addCustomer(name, birth, address, phonenumber);
                MessageBox.Show("Thêm khách hàng thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                Clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được tài khoản", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string newname = txtNAME.Text;
                string newbirth = dtpBirthDate.Text;
                string newphonenumber = txtPhoneNumber.Text;
                string newaddress = txtAddress.Text;
                DataProvider provider = new DataProvider();
                provider.editCustomer(newname, newbirth, newphonenumber, newaddress, oldname);
                MessageBox.Show("Chỉnh sửa thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                Clear();
            }
            catch
            {
                MessageBox.Show("Không chỉnh sửa được ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtSearch.Text;
                DataProvider provider = new DataProvider();
                provider.searchCustomer(name);
                //MessageBox.Show("Tìm kiếm thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadSeacrh(name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string name = txtNAME.Text;
                    DataProvider provider = new DataProvider();
                    provider.delCustomer(name);
                    MessageBox.Show("Xóa thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntExit_Click_1(object sender, EventArgs e)
        {
            fMain m = new fMain();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvCustomerList.Rows[e.RowIndex];
                txtNAME.Text = row.Cells[0].Value.ToString();
                oldname = row.Cells[0].Value.ToString();
                dtpBirthDate.Text = row.Cells[1].Value.ToString();
                txtPhoneNumber.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
