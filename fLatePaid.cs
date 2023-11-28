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
    public partial class fLatePaid : Form
    {
        public fLatePaid()
        {
            InitializeComponent();
            dtpPaidDate.ValueChanged += new EventHandler(dtpPaidDate_ValueChanged);
            dtpLatePaidDate.ValueChanged += new EventHandler(dtpPaidDate_ValueChanged);
        }

        private void loadCN()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadCustomerName();
            cbCustomer.DisplayMember = "Name";
            cbCustomer.DataSource = table;
        }

        private void loadBN()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadBookName();
            cbBook.DisplayMember = "Bookname";
            cbBook.DataSource = table;
        }

        private void loadL()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadLatePaid();
            dtgvLatePaidList.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadCN();
            loadBN();
            loadL();
        }

        private void dtpPaidDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime paiddate = Convert.ToDateTime(dtpPaidDate.Text);
            DateTime latedate = Convert.ToDateTime(dtpLatePaidDate.Text);
            if (latedate >= paiddate)
            {
                txtLateDate.Text = latedate.Subtract(paiddate).Days.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fMain m = new fMain();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa không ?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string customename = cbCustomer.Text;
                    DataProvider provider = new DataProvider();
                    provider.delLatePaid(customename);
                    MessageBox.Show("Xóa thành công", "Notice", MessageBoxButtons.OK);
                    loadL();
                }

            }
            catch
            {
                MessageBox.Show("Đã có lỗi","Notice",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvLatePaidList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvLatePaidList.Rows[e.RowIndex];
                cbCustomer.Text = row.Cells[1].Value.ToString();
                cbBook.Text = row.Cells[2].Value.ToString();
                nmudNumber.Text = row.Cells[3].Value.ToString();
                dtpPaidDate.CustomFormat = row.Cells[4].Value.ToString();
                
                dtpLatePaidDate.Text = row.Cells[5].Value.ToString();
                txtLateDate.Text = row.Cells[6].Value.ToString();
                txtLateBook.Text = row.Cells[7].Value.ToString();
                txtSum.Text = row.Cells[8].Value.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string customername = cbCustomer.Text;
            string bookname = cbBook.Text;
            string quantity = nmudNumber.Text;
            string paiddate = dtpPaidDate.Text;
            string latepaiddate = dtpLatePaidDate.Text;
            string daylate = txtLateDate.Text;
            string booklate = txtLateBook.Text;
            string fee = txtSum.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addLatePaid(customername, bookname, quantity, paiddate, latepaiddate, daylate, booklate, fee);
                MessageBox.Show("Tạo phiếu trả muộn thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadL();
            }
            catch
            {
                MessageBox.Show("Không lập được phiếu trả muộn", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(txtLateDate.Text);
            int m;
            m = int.Parse(txtLateBook.Text);
            int s = 0;
            s = n * m;
            txtSum.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(nmudNumber.Text);
            int s = 0;
            s = n * 10000;
            txtLateBook.Text = s.ToString();
        }
    }
}
