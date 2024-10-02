using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501_E1_Q5
{
    public class Book
    {
        private int _pages;

        private string[] _content;

        private int _currentPage;

        private List<int> _bookmarks;

        private string _title;

        public string Title => _title;

        public Book(int pages, string[] content, int currentPage, List<int> bookmarks, string title)
        {
            _pages = pages;
            _content = content;
            _currentPage = currentPage;
            _bookmarks = bookmarks;
            _title = title;
        }

        public string GetPage(int page)
        {
            return _content[page];
        }

        public string GetCurrentPage()
        {
            return _content[_currentPage];
        }

        public void AddBookMark(int page)
        {
            if (!_bookmarks.Contains(page))
            {
                _bookmarks.Add(page);
            }
        }

        public void RemoveBookmark(int page)
        {
            _bookmarks.Remove(page);
        }
    }
}
