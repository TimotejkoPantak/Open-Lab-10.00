using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    public class Book
    {
        public string Title
        {
            get => title;
            set => title = value;
        }

        public int Pages
        {
            get => pages;
            set => pages = value;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public int ReleaseDate
        {
            get => releaseDate;
            set => releaseDate = value;
        }

        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;


        public void Statement()
        {
            Console.WriteLine($"{Title},{Pages},{Category},{Author},{ReleaseDate}");
        }
    }
}
