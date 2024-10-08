using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private SendBookDel SendBook;

        public LibraryView(SendBookDel sendBook)
        {
            InitializeComponent();

            SendBook = sendBook;
        }

        public void UpdateLibrary(ReadOnlyCollection<Book> books)
        {
            BookListBox.DataSource = books;
        }
        private void uxOpenBookButton_Click(object sender, EventArgs e)
        {
            SendBook((Book)BookListBox.SelectedItem);
        }

        private void LibraryView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // True if the selected item is a book.
            uxOpenBookButton.Enabled = BookListBox.SelectedItem is Book ? true : false;
        }
    }
}
