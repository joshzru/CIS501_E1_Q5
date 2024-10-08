using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS501_E1_Q5
{
    public delegate string GetPageDel(Book book, int pageNum);

    public delegate void UpdateBookButtonsDel(bool nextPageButton, bool previousPageButton, bool addBookmarkButton, bool removeBookmarkButton);

    public delegate void HandleBookmarkDel(Book book, int pageNum);

    public delegate bool HandlePageChangeDel(Book book, int pageNum);

    public delegate void SendBookDel(Book book);

    public delegate void UpdateLibraryDel(ReadOnlyCollection<Book> books);
}
