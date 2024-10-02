using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501_E1_Q5
{
    public class LibraryController
    {
        private List<Book> _books = new();

        private DataSyncDel? DataSyncDel;

        public LibraryController()
        {
        }

        public void AttachDelToController(DataSyncDel dataSyncDel)
        {
            DataSyncDel = dataSyncDel;
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            // implement this.
        }
    }
}
