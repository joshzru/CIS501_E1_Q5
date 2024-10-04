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
            #region book filler
            string[] contents = new string[10];
            for (int i = 0; i < 10; i++)
            {
                contents[i] = "The Quick Brown Fox Lept over the MOON: " + i.ToString();
            }
            Book construct = new Book(10, contents, new List<int>(), "Alpha");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Beta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Zeta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Treta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Nreta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Neeta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Gretcha");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Bretcha");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Popta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Jeta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Keta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Nocta");
            AddBook(construct);
            construct = new Book(10, contents, new List<int>(), "Bees");
            AddBook(construct);
            #endregion
        }

        public void AttachDelToController(DataSyncDel dataSyncDel)
        {
            DataSyncDel = dataSyncDel;
            DataSyncDel(_books);
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
            for(int x = 0; x < _books.Count - 1; x++)
            {
                for (int j = 0; j < _books.Count - x - 1; j++)
                {
                    string title = _books[j].Title;
                    char[] letters = title.ToCharArray();
                    title = _books[j + 1].Title;
                    char[] lettersTwo = title.ToCharArray();
                    if (letters[0] > lettersTwo[0])
                    {
                        Book temp = _books[j];
                        _books[j] = _books[j + 1];
                        _books[j + 1] = temp;
                    }
                    if (letters[0] == lettersTwo[0])
                    {
                        if (letters.Length > 2 && lettersTwo.Length > 2)
                        {
                            if (letters[1] > lettersTwo[1])
                            {
                                Book temp = _books[j];
                                _books[j] = _books[j + 1];
                                _books[j + 1] = temp;
                            }
                        }
                        if (letters[1] == lettersTwo[1])
                        {
                            if (letters.Length > 3 && lettersTwo.Length > 3)
                            {
                                if (letters[2] > lettersTwo[2])
                                {
                                    Book temp = _books[j];
                                    _books[j] = _books[j + 1];
                                    _books[j + 1] = temp;
                                }
                            }
                        }
                    }
                    
                }
            }
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            List<Book> booksList = _books;
            foreach (Book x in booksList)
            {
                if (x.Title.Equals(book.Title))
                {
                    RemoveBook(x);
                    AddBook(book);
                    break;
                }
            }
            if (DataSyncDel == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                DataSyncDel(_books);
            }

        }
    }
}
