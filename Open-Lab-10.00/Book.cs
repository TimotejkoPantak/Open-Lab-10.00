using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }

        


        public void BookInfo(string title, int pages, string category,string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public void Statement()
        {
            Console.WriteLine($"{Title},{Pages},{Category},{Author},{ReleaseDate}");
        }


        
    }
}
