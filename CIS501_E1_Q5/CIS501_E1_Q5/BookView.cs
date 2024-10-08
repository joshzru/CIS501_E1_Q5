using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501_E1_Q5
{
    public partial class BookView : Form
    {
        private Book? _book;

        private GetPageDel GetPage;

        private HandleBookmarkDel AddBookmark;

        private HandleBookmarkDel RemoveBookmark;

        private HandlePageChangeDel HandlePageChange;

        public BookView(HandleBookmarkDel addBookmark, HandleBookmarkDel removeBookmark, HandlePageChangeDel handlePageChange, GetPageDel getPage)
        {
            InitializeComponent();

            AddBookmark = addBookmark;
            RemoveBookmark = removeBookmark;
            HandlePageChange = handlePageChange;
            GetPage = getPage;
        }

        public void SetBook(Book book)
        {
            _book = book;
            Text = book.Title;

            PageTextBox.Text = GetPage(book, book.CurrentPage);
            Show();
        }

        private void BookView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void uxPreviousPageButton_Click(object sender, EventArgs e)
        {
            if (_book is Book book)
            {
                if (!HandlePageChange(book, book.CurrentPage - 1))
                {
                    MessageBox.Show("Error in book: Page does not exist.");
                }
            }
        }

        private void uxGoToPageButton_Click(object sender, EventArgs e)
        {
            if (_book is Book book)
            {
                if (!HandlePageChange(book, Int32.Parse(GoToPageTextBox.Text)))
                {
                    MessageBox.Show("Error in book: Page does not exist.");
                }
            }
        }

        public void SetButtonStates(bool nextPageButton, bool previousPageButton, bool addBookmarkButton, bool removeBookmarkButton)
        {
            SetPageButtons(nextPageButton, previousPageButton);
            SetBookmarkButtons(addBookmarkButton, removeBookmarkButton);
        }

        private void SetPageButtons(bool nextPageEnabled, bool previousPageEnabled)
        {
            uxNextPageButton.Enabled = nextPageEnabled;
            uxPreviousPageButton.Enabled = previousPageEnabled;
        }

        private void uxRemoveBookmarkButton_Click(object sender, EventArgs e)
        {
            if (_book is Book book)
            {
                RemoveBookmark(book, book.CurrentPage);
            }
        }

        private void uxAddBookMarkButton_Click(object sender, EventArgs e)
        {
            if (_book is Book book)
            {
                AddBookmark(book, book.CurrentPage);
            }
        }

        private void SetBookmarkButtons(bool addBookmarkEnabled, bool removeBookmarkEnabled)
        {
            uxAddBookMarkButton.Enabled = addBookmarkEnabled;
            uxRemoveBookmarkButton.Enabled = removeBookmarkEnabled;
        }

        private void uxNextPageButton_Click(object sender, EventArgs e)
        {
            if (_book is Book book)
            {
                if (!HandlePageChange(book, book.CurrentPage + 1))
                {
                    MessageBox.Show("Error in book: Page does not exist.");
                }
            }
        }

        private void GoToPageTextBox_TextChanged(object sender, EventArgs e)
        {
            // Ask if this validation should be done in the controller, or if its fine to be done inside the view.
            if (_book is Book book)
            {
                if (Int32.TryParse(GoToPageTextBox.Text, out int result))
                {
                    uxGoToPageButton.Enabled = true;
                }
                else
                {
                    uxGoToPageButton.Enabled = false;
                }
            }
        }
    }
}
