using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int index;
        public LibraryIterator(List<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            ++index;
            return index < books.Count; 
        }

        public void Reset()
        {
            this.index = -1;
        }
        public void Dispose()
        {
            
        }
    }
}
