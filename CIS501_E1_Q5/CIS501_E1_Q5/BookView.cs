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
        }

        private void BookView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // implement this
        }
    }
}
