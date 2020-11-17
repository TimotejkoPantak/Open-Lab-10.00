using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
     public class Book
    { 
        public void Informations(string title, int pages, string category, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;
            Category = category;
            Author = author;
            ReleaseDate = releaseDate;
        }

        private string Title { get; set; }
        private int Pages { get; set; }
        private string Category { get; set; }
        private string Author { get; set; }
        private int ReleaseDate { get; set; }

        public void Statement()
        {
            Console.WriteLine($"{Title}, {Pages}, {Category}, {Author}, {ReleaseDate}");
        }
        
       }
}
