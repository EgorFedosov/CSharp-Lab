using System;
namespace Pet_2
{
    struct Lib
    {
        private string BookTitle;
        public string _BookTitle
        {
            get { return this.BookTitle; }
            private set { }
        }

        private string AuthorBook;
        public string _AuthorBook
        {
            get { return this.AuthorBook; }
            private set { }
        }

        private short Year_of_Publication;
        public short _Year_of_Publication
        {
            get { return this.Year_of_Publication; }
            private set { }
        }

        private ushort count = 1;

        public ushort _count
        {
            get { return this.count; }
            private set { }
        }

        public Lib(string BookTitle, string AuthorBook, short Year_of_Publication, ushort _count)
        {
            this.BookTitle = BookTitle;
            this.AuthorBook = AuthorBook;
            this.Year_of_Publication = Year_of_Publication;
            this.count = _count;
        }
        public static bool flag = false;

        public bool Search(string book_title)
        {
            return BookTitle == book_title;
        }

        /*
        это получше class Book
        {
            private static int count = 0; // Статическая переменная для подсчета экземпляров

            private string _bookTitle;
            private string _authorBook;
            private short _yearOfPublication;

            // Конструктор класса
            public Book(string bookTitle, string authorBook, short yearOfPublication)
            {
                _bookTitle = bookTitle;
                _authorBook = authorBook;
                _yearOfPublication = yearOfPublication;
                count++;
            }

            // Свойства для доступа к приватным полям
            public string BookTitle
            {
                get { return _bookTitle; }
                set { _bookTitle = value; }
            }

            public string AuthorBook
            {
                get { return _authorBook; }
                set { _authorBook = value; }
            }

            public short YearOfPublication
            {
                get { return _yearOfPublication; }
                set { _yearOfPublication = value; }
            }

            // Метод без параметров, использующий свойства объекта
            public void Print()
            {
                Console.WriteLine($"{count}. {BookTitle} - {AuthorBook} ({YearOfPublication})");
            }
        }

        */

        public void print()
        {
            Console.WriteLine($"{_count}. {_BookTitle} - {_AuthorBook}({_Year_of_Publication})");
        }

        public void PrintCount()
        {
            Console.WriteLine(count);
        }
    }

}