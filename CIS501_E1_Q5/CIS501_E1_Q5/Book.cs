using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501_E1_Q5
{
    public class Book
    {
        private string[] _content;

        private List<int> _bookmarks;
        
        public int CurrentPage;
        
        public int Pages;

        public string Title;

        public List<int> BookMarks => _bookmarks;

        public Book(int pages, string[] content, List<int> bookmarks, string title)
        {
            Pages = pages;
            _content = content;
            CurrentPage = 0;
            _bookmarks = bookmarks;
            Title = title;
        }

        public string GetPage(int page)
        {
            return _content[page];
        }

        public string GetCurrentPage()
        {
            return _content[CurrentPage];
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
