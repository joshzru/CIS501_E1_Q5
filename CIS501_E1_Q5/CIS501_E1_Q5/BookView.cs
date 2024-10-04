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
        public Book _book;

        public BookView(Book b)
        {
            InitializeComponent();

            _book = b;
            Text = _book.Title;
            BookPageLabel.Text = _book.GetCurrentPage();
            if (_book.CurrentPage == 0)
            {
                uxPreviousPageButton.Enabled = false;
                uxNextPageButton.Enabled = true;
            }
            if (_book.CurrentPage == _book.Pages - 1)
            {
                uxPreviousPageButton.Enabled = true;
                uxNextPageButton.Enabled = false;
            }
            if (_book.BookMarks.Contains(_book.CurrentPage))
            {
                uxAddBookMarkButton.Enabled = false;
                uxRemoveBookmarkButton.Enabled = true;
            }
            else
            {
                uxAddBookMarkButton.Enabled = true;
                uxRemoveBookmarkButton.Enabled = false;
            }           
        }

        private void BookView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            e.Cancel = true;
        }

        private void uxPreviousPageButton_Click(object sender, EventArgs e)
        {
            _book.CurrentPage -= 1;
            BookPageLabel.Text = _book.GetCurrentPage();
            if (_book.CurrentPage == 0)
            {
                uxPreviousPageButton.Enabled = false;
                uxNextPageButton.Enabled = true;
            }
            else
            {
                uxPreviousPageButton.Enabled = true;
                uxNextPageButton.Enabled = true;
            }
            if (_book.BookMarks.Contains(_book.CurrentPage))
            {
                uxAddBookMarkButton.Enabled = false;
                uxRemoveBookmarkButton.Enabled = true;
            }
            else
            {
                uxAddBookMarkButton.Enabled = true;
                uxRemoveBookmarkButton.Enabled = false;
            }
        }

        private void uxGoToPageButton_Click(object sender, EventArgs e)
        {
            string text = GoToPageTextBox.Text;
            int number = 0;
            try
            {
                number = Convert.ToInt32(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid number or number exceeds the number of pages");
                return;
            }
            
            if (number < _book.Pages + 1 && number > 0)
            {
                _book.CurrentPage = number - 1;
                BookPageLabel.Text = _book.GetCurrentPage();
                if (_book.CurrentPage == 0)
                {
                    uxPreviousPageButton.Enabled = false;
                    uxNextPageButton.Enabled = true;
                }
                if (_book.CurrentPage == _book.Pages - 1)
                {
                    uxPreviousPageButton.Enabled = true;
                    uxNextPageButton.Enabled = false;
                }
                if (_book.BookMarks.Contains(_book.CurrentPage))
                {
                    uxAddBookMarkButton.Enabled = false;
                    uxRemoveBookmarkButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid number or number exceeds the number of pages");
            }
        }

        private void uxRemoveBookmarkButton_Click(object sender, EventArgs e)
        {
            _book.RemoveBookmark(_book.CurrentPage);
            uxAddBookMarkButton.Enabled = true;
            uxRemoveBookmarkButton.Enabled = false;
        }

        private void uxAddBookMarkButton_Click(object sender, EventArgs e)
        {
            _book.AddBookMark(_book.CurrentPage);
            uxAddBookMarkButton.Enabled = false;
            uxRemoveBookmarkButton.Enabled = true;
        }

        private void uxNextPageButton_Click(object sender, EventArgs e)
        {
            _book.CurrentPage += 1;
            BookPageLabel.Text = _book.GetCurrentPage();
            if (_book.CurrentPage == _book.Pages - 1)
            {
                uxPreviousPageButton.Enabled = true;
                uxNextPageButton.Enabled = false;
            }
            else
            {
                uxPreviousPageButton.Enabled = true;
                uxNextPageButton.Enabled = true;
            }
            if (_book.BookMarks.Contains(_book.CurrentPage))
            {
                uxAddBookMarkButton.Enabled = false;
                uxRemoveBookmarkButton.Enabled = true;
            }
            else
            {
                uxAddBookMarkButton.Enabled = true;
                uxRemoveBookmarkButton.Enabled = false;
            }
        }

        private void GoToPageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
