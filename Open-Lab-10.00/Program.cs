using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Informations("Harry Potter", 430);
            Console.WriteLine(LOTR.Title);
        }
    }
}
