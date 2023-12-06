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
    public partial class fGenresManagerment : Form
    {
        public fGenresManagerment()
        {
            InitializeComponent();
        }

        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadGenres();
            dtgvGenresList.DataSource = table;
        }

        private void clear()
        {
            txtGenres.Clear();
        }

        private void fGenresManagerment_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtgvGenresList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvGenresList.Rows[0];
                txtGenres.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string genresname = txtGenres.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addGenres(genresname);
                MessageBox.Show("Thêm thể loại thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không thêm được thể loại", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa thể loại ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string genresname = txtGenres.Text;
                    DataProvider provider = new DataProvider();
                    provider.delGenres(genresname);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
