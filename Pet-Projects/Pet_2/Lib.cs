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

        public Lib(string BookTitle, string AuthorBook, short Year_of_Publication)
        {
            this.BookTitle = BookTitle;
            this.AuthorBook = AuthorBook;
            this.Year_of_Publication = Year_of_Publication;
        }
        public static bool flag = false;

        public bool Search(string book_title)
        {
            return BookTitle == book_title;
        }

        public void print()
        {
            Console.WriteLine($"{_BookTitle} - {_AuthorBook}({_Year_of_Publication})");
        }
    }

}