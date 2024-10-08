using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501_E1_Q5
{
    public class Book
    {
        private string[] _content;

        public ReadOnlyCollection<string> Content => Array.AsReadOnly<string>(_content);

        private List<int> _bookmarks;
        public ReadOnlyCollection<int> Bookmarks => _bookmarks.AsReadOnly();

        private int _currentPage;

        public int CurrentPage => _currentPage;
        
        public int Pages;

        public string Title;

        public Book(int pages, string[] content, List<int> bookmarks, string title, int currentPage = 0)
        {
            Pages = pages;
            _content = content;
            _currentPage = currentPage;
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

        public override string ToString()
        {
            return Title;
        }
    }
}
