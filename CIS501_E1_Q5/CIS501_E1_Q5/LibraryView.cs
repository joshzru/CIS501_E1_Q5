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

        private Book? _selectedBook;

        private BookModifiedDel BookModifiedDel;

        public LibraryView(BookModifiedDel bookModified)
        {
            InitializeComponent();

            BookModifiedDel = bookModified;
        }

        public void SyncData(List<Book> bookList)
        {
            // implement this
        }

        private void LibraryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // implement this
        }

        private void uxOpenBookButton_Click(object sender, EventArgs e)
        {
            // Implement this
        }

        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implement this
        }
    }
}
