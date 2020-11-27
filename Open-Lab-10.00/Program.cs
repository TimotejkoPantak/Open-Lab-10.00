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
            LOTR.Author = "J.K. Rowling";
            LOTR.ReleaseDate = 2010;
            if (LOTR.ReleaseDate <= 1450 || LOTR.ReleaseDate >= 2020)
            {
                LOTR.ReleaseDate = -1;
            }

            if(LOTR.Pages < 0)
            {
                LOTR.Pages = 1;
            }

            Console.WriteLine($"{LOTR.Title},{LOTR.Pages},{LOTR.Category},{LOTR.Author},{LOTR.ReleaseDate}");
        }

    }
}
