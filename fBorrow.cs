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
    public partial class fBorrow : Form
    {
        public fBorrow()
        {
            InitializeComponent();
        }
        private void loadCN()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = provider.loadCustomerName();
            cbCustomer.DisplayMember = "Name";
            cbCustomer.DataSource = dt;
        }
        private void loadBN()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = provider.loadBookName();
            cbBook.DisplayMember = "Bookname";
            cbBook.DataSource = dt;
        }
        private void loadB()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = provider.loadBorrow();
            dtgvBorrow.DataSource = dt;
        }
        private void fBorrow_Load(object sender, EventArgs e)
        {
            loadCN();
            loadBN();
            loadB();
        }

        private void dtgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvBorrow.Rows[e.RowIndex];
                cbCustomer.Text = row.Cells[1].Value.ToString();
                cbBook.Text = row.Cells[2].Value.ToString();
                nmSoLuong.Text = row.Cells[3].Value.ToString();
                dpNgayMuon.Text = row.Cells[4].Value.ToString();
                dpNgayTra.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            string customername = cbCustomer.Text;
            string bookname = cbBook.Text;
            string quantity = nmSoLuong.Text;
            string borrowdate = dpNgayMuon.Text;
            string paiddate = dpNgayTra.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addBorrow(customername, bookname, quantity, borrowdate, paiddate);
                MessageBox.Show("Tạo phiếu mượn thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadB();
            }
            catch
            {
                MessageBox.Show("Không lập được phiếu mượn", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string customername = cbCustomer.Text;
                    DataProvider provider = new DataProvider();
                    provider.delBorrow(customername);
                    MessageBox.Show("Xóa thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadB();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            fMain main = new fMain();
            this.Hide();
            this.ShowDialog();
        }
    }
}
