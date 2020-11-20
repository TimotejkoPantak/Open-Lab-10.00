using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "Harry Potter";
            LOTR.Pages = 430;
            LOTR.Category = "Fantasy";
            LOTR.Author = "J.K.Rowling";
            LOTR.ReleaseDate = 2010;
            LOTR.Statement();
           
        }

    }
}
