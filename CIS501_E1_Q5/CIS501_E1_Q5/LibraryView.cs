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
    public partial class LibraryView : Form
    {
        private List<Book> _books;

        private Book _selectedBook;

        private BookModifiedDel BookModifiedDel;

        public LibraryView(BookModifiedDel bookModified)
        {
            InitializeComponent();

            BookModifiedDel = bookModified;
            _books = new List<Book>();
        }

        public void SyncData(List<Book> bookList)
        {
            _books = bookList;
            BookListBox.Items.Clear();
            foreach (Book book in _books) 
            { 
                BookListBox.Items.Add(book.Title);
            }
        }

        private void LibraryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // implement this
        }

        private void uxOpenBookButton_Click(object sender, EventArgs e)
        {
            BookView bookView = new BookView(_selectedBook);
            bookView.ShowDialog();
            Book modified = bookView._book;
            bookView.Dispose();
            BookModifiedDel(modified);
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedItems.Count > 0)
            {
                uxOpenBookButton.Enabled = true;
                _selectedBook = _books[BookListBox.SelectedIndex];
            }
            else
            {
                uxOpenBookButton.Enabled = false;
            }
        }
    }
}
