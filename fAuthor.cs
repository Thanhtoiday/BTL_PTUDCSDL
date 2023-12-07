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
    public partial class fAuthor : Form
    {
        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAuthor();
            dtgvAuthorList.DataSource = table;

        }
        private void clear()
        {
            txtAuthorName.Clear();
        }
        public fAuthor()
        {
            InitializeComponent();
        }

        private void fAuthor_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtgvAuthorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvAuthorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string authorname = txtAuthorName.Text;
            string yeardate = txtYear.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addAuthor(authorname, yeardate);
                MessageBox.Show("Thêm tác giả thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được tác giả", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            string authorname = txtAuthorName.Text;
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa tác giả ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataProvider provider = new DataProvider();
                    provider.delAuthor(authorname);
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
