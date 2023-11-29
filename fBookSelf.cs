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
    public partial class fBookSelf : Form
    {
        public fBookSelf()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadBooKSelf();
            dtgvSelfList.DataSource = table;
        }

        private void clear()
        {
            txtBookSelf.Clear();
        }

        private void fBookSelf_Load(object sender, EventArgs e)
        {
            load();
        }
        private void dtgvSelfList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvSelfList.Rows[e.RowIndex];
                txtBookSelf.Text = row.Cells[0].Value.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookselfname = txtBookSelf.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addBookSelf(bookselfname);
                MessageBox.Show("Thêm kệ sách thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được giá sách", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bntDel_Click(object sender, EventArgs e)
        {
            string bookselfname = txtBookSelf.Text;
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa giá sách", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataProvider provider = new DataProvider();
                    provider.delBookSelf(bookselfname);
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
    }
}
