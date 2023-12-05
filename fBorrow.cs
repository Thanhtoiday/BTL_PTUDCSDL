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
    }
}
