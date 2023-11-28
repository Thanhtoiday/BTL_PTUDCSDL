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
    public partial class fPublisher : Form
    {
        public fPublisher()
        {
            InitializeComponent();
        }

        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = provider.loadPublisher();
            dtgvPublisherList.DataSource = dt;
        }
        private void clear()
        {
            txtPublisherName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }
        private void fPublisher_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtgvPublisherList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
               DataGridViewRow row = dtgvPublisherList.Rows[e.RowIndex];
                txtPublisherName.Text = row.Cells[0].Value.ToString();
                txtAddress.Text = row.Cells[1].Value.ToString();
                txtPhoneNumber.Text = row.Cells[2].Value.ToString();
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            string publishername = txtPublisherName.Text;
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa nhà xuất bản ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataProvider provider = new DataProvider();
                    provider.delPublisher(publishername);
                    MessageBox.Show("Xóa thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                    clear();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string publishername = txtPublisherName.Text;
            string address = txtAddress.Text;
            string phone = txtPhoneNumber.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addPublisher(publishername, address, phone);
                MessageBox.Show("Thêm nhà xuất bản thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không thể thêm nhà xuất bản", "Notice", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
