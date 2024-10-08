using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501_E1_Q5
{
    public class LibraryController
    {
        private List<Book> _books = new();

        private SendBookDel? SendBook;

        private UpdateBookButtonsDel? UpdateBookButtons;

        private UpdateLibraryDel? UpdateLibrary;

        public LibraryController()
        {
            #region book filler
            string[] contents = new string[10];
            for (int i = 0; i < 10; i++)
            {
                contents[i] = "The Quick Brown Fox Lept over the MOON: " + (i).ToString();
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

        public void AttachBookDels(SendBookDel sendBook, UpdateBookButtonsDel updateBookButtons)
        {
            SendBook = sendBook;
            UpdateBookButtons = updateBookButtons;
        }

        public void AttachLibraryDels(UpdateLibraryDel updateLibrary)
        {
            UpdateLibrary = updateLibrary;
            UpdateLibrary(_books.AsReadOnly());
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

        public void SetBookView(Book book)
        {
            SendBook?.Invoke(book);
            ValidateBook(book);
        }

        public void AddBookmark(Book book, int pageNum)
        {
            List<int> bookmarks = book.Bookmarks.ToList();
            bookmarks.Add(pageNum);

            Book newBook = new(book.Pages, book.Content.ToArray(), bookmarks, book.Title, book.CurrentPage);

            _books.Remove(book);
            _books.Add(newBook);

            SortBooks();

            UpdateLibrary?.Invoke(_books.AsReadOnly());
            SendBook?.Invoke(newBook);
            ValidateBook(newBook);
        }

        public void RemoveBookmark(Book book, int pageNum)
        {
            List<int> bookmarks = book.Bookmarks.ToList();
            bookmarks.Remove(pageNum);

            Book newBook = new(book.Pages, book.Content.ToArray(), bookmarks, book.Title, book.CurrentPage);

            _books.Remove(book);
            _books.Add(newBook);

            SortBooks();

            UpdateLibrary?.Invoke(_books.AsReadOnly());
            SendBook?.Invoke(newBook);
            ValidateBook(newBook);
        }

        public bool ChangePage(Book book, int pageNum)
        {
            if (pageNum < 0 || pageNum >= book.Pages)
            {
                return false;
            }

            Book newBook = new(book.Pages, book.Content.ToArray(), book.Bookmarks.ToList(), book.Title, pageNum);

            _books.Remove(book);
            _books.Add(newBook);

            SortBooks();

            UpdateLibrary?.Invoke(_books.AsReadOnly());
            SendBook?.Invoke(newBook);
            ValidateBook(newBook);

            return true;
        }

        public string ReturnPage(Book book, int pageNum)
        {
            // Returns the page at the pageNum if pageNum is between the number of
            // pages in the book minus 1 and 0, null otherwise.
            return book.GetPage(pageNum);
        }

        private void SortBooks()
        {
            _books.Sort((book1, book2) =>
            {
                return book1.Title.CompareTo(book2.Title);
            });
        }

        private void ValidateBook(Book book)
        {
            // True if the current page is less than the number of Pages minus 1 (minus 1 because we want to exclude the last page).
            bool nextPageButton = book.CurrentPage < book.Pages - 1 ? true : false;

            // True if the current page is greater than 0 (strictly greater than because we want to exclude the first page).
            bool previousPageButton = book.CurrentPage > 0 ? true : false;

            // True if the books list of bookmarks does not already contain the current page and 
            // there are less than 5 bookmarsk in the list.
            bool addBookmarkButton = !book.Bookmarks.Contains(book.CurrentPage) && book.Bookmarks.Count < 5 ? true : false;

            // True if the books list of bookmarks contains the current page.
            bool removeBookmarkButton = book.Bookmarks.Contains(book.CurrentPage) ? true : false;

            UpdateBookButtons?.Invoke(nextPageButton, previousPageButton, addBookmarkButton, removeBookmarkButton);
        }
    }
}
