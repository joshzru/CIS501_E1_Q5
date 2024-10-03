using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501_E1_Q5
{
    public partial class BookView : Form
    {
        private Book _book;

        public BookView(Book book)
        {
            InitializeComponent();

            _book = book;
            Text = book.Title;
            BookPageLabel.Text = book.GetCurrentPage();
        }

        private void BookView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // implement this
        }

        private void uxPreviousPageButton_Click(object sender, EventArgs e)
        {

        }

        private void uxGoToPageButton_Click(object sender, EventArgs e)
        {

        }

        private void uxRemoveBookmarkButton_Click(object sender, EventArgs e)
        {

        }

        private void uxAddBookMarkButton_Click(object sender, EventArgs e)
        {

        }

        private void uxNextPageButton_Click(object sender, EventArgs e)
        {

        }

        private void GoToPageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
