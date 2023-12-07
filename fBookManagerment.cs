using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBTLQlyTV
{
    public partial class fBookManagerment : Form
    {
        string oldname;
        public fBookManagerment()
        {
            InitializeComponent();
        }

        private void load()
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadBook();
            dtgvBookList.DataSource = table;
        }

        private void fBookManagerment_Load(object sender, EventArgs e)
        {
            load();
        }

        private void clear()
        {
            txtName.Clear();
            txtYear.Clear();
            txtGenres.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtBookSelf.Clear();
        }

        private void loadSearchByBookName(string bookname)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchBookByBookName(bookname);
            dtgvBookList.DataSource = table;
        }

        private void loadSearchByGenres(string genres)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchBookByGenres(genres);
            dtgvBookList.DataSource = table;
        }

        private void loadSearchByReleaseYear(string releaseyear)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchBookByReleaseYear(releaseyear);
            dtgvBookList.DataSource = table;
        }

        private void loadSearchByAuthor(string author)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchBookByAuthor(author);
            dtgvBookList.DataSource = table;
        }

        private void loadSearchByPublisher(string publisher)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchBookByPublisher(publisher);
            dtgvBookList.DataSource = table;
        }

        private void loadSearchByBookSelf(string bookself)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.searchBookByBookSelf(bookself);
            dtgvBookList.DataSource = table;
        }

        private void dtgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtgvBookList.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                oldname = row.Cells[1].Value.ToString();
                txtYear.Text = row.Cells[2].Value.ToString();
                txtGenres.Text = row.Cells[3].Value.ToString();
                txtAuthor.Text = row.Cells[4].Value.ToString();
                txtPublisher.Text = row.Cells[5].Value.ToString();
                txtBookSelf.Text = row.Cells[6].Value.ToString();
                nmudNumber.Text = row.Cells[7].Value.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nmudNumber_ValueChanged(object sender, EventArgs e)
        {

        }
        //Thêm sách
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string bookname = txtName.Text;
            string releaseyear = txtYear.Text;
            string genres = txtGenres.Text;
            string author = txtAuthor.Text;
            string publisher = txtPublisher.Text;
            string bookself = txtBookSelf.Text;
            string quantity = nmudNumber.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.addBook(bookname, releaseyear, genres, author, publisher, bookself, quantity);
                MessageBox.Show("Thêm sách thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Xóa sách
        private void bntDel_Click(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(txtDel.Text);
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa sách", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    DataProvider provider = new DataProvider();
                    provider.delBook(id);
                    MessageBox.Show("Xóa thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Lưu thành công", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Sửa sách
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newbookname = txtName.Text;
            string newreleaseyear = txtYear.Text;
            string newgenres = txtGenres.Text;
            string newauthor = txtAuthor.Text;
            string newpublisher = txtPublisher.Text;
            string newbookself = txtBookSelf.Text;
            string newquantity = nmudNumber.Text;
            try
            {
                DataProvider provider = new DataProvider();
                provider.editBook(newbookname, newreleaseyear, newgenres, newauthor, newpublisher, newbookself, newquantity, oldname);
                MessageBox.Show("Chỉnh sửa thành công ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load();
                clear();
            }
            catch
            {
                MessageBox.Show("Không chỉnh sửa được ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Tìm kiếm theo tên sách
        private void btnFind1_Click(object sender, EventArgs e)
        {
            if (txtNameS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string bookname = txtNameS.Text;
            DataProvider provider = new DataProvider();
            provider.searchBookByBookName(bookname);
            loadSearchByBookName(bookname);
        }
        //Tìm kiếm theo thể loại
        private void btnFind2_Click(object sender, EventArgs e)
        {
            if (txtGenresS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string genres = txtGenresS.Text;
            DataProvider provider = new DataProvider();
            provider.searchBookByGenres(genres);
            loadSearchByGenres(genres);
        }
        //Tìm kiếm theo năm phát hành
        private void btnfind3_Click(object sender, EventArgs e)
        {
            if (txtYearS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string releaseyear = txtYearS.Text;
            DataProvider provider = new DataProvider();
            provider.searchBookByReleaseYear(releaseyear);
            loadSearchByReleaseYear(releaseyear);
        }
        //Tìm kiếm theo tác giả
        private void btnFind4_Click(object sender, EventArgs e)
        {
            if (txtAuthorS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string author = txtAuthorS.Text;
            DataProvider provider = new DataProvider();
            provider.searchBookByAuthor(author);
            loadSearchByAuthor(author);
        }
        //Tìm kiếm theo nhà xuất bản
        private void btnFind5_Click(object sender, EventArgs e)
        {
            if (txtPublisherS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string publisher = txtPublisherS.Text;
            DataProvider provider = new DataProvider();
            provider.searchBookByPublisher(publisher);
            loadSearchByPublisher(publisher);
        }

        private void btnfind6_Click(object sender, EventArgs e)
        {
            if (txtBookSelfS.Text == "")
            {
                MessageBox.Show("Chưa nhập thông tin cần tìm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string bookself = txtBookSelfS.Text;
            DataProvider provider = new DataProvider();
            provider.searchBookByBookSelf(bookself);
            loadSearchByBookSelf(bookself);
        }

        private void btnReset_Click(object sender, EventArgs e)
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
    }
}
