﻿using System;
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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPublisher p = new fPublisher();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void lậpPhiếuTrảMuộnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLatePaid lp = new fLatePaid();
            this.Hide();
            lp.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn đăng xuất", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                fLogin login = new fLogin();
                this.Hide();
                login.ShowDialog();
                this.Show();
            }
        }

        private void kệSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBookSelf b = new fBookSelf();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountManagement Account = new fAccountManagement();
            this.Hide();
            Account.ShowDialog();
            this.Show();
        }

        private void sáchMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBorrow borrow = new fBorrow();
            this.Close();
            borrow.ShowDialog();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAuthor tg = new fAuthor();
            this.Close();
            tg.ShowDialog();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBookManagerment bm = new fBookManagerment();
            this.Close();
            bm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCustomerManagerment cm = new fCustomerManagerment();
            this.Hide();
            cm.ShowDialog();
            this.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fGenresManagerment g = new fGenresManagerment();
            this.Hide();
            g.ShowDialog();
            this.Show();
        }
    }
}
