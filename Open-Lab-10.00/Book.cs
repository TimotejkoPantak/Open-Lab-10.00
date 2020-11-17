using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
     public class Book
    { 
        public void Informations(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public string Title { get; set; }
        private int Pages { get; set; }
    }
}
