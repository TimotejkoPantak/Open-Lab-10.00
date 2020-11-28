using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running == true)
            {
                Console.WriteLine("Choose some book : \nLOTR \nLOTR2 \nLOTR3\nHOBIT\n\n");
                string choose = Console.ReadLine();
                if (choose == "LOTR")
                {
                    Book LOTR = new Book("H. Potter", 430, "Fantasy", "J.K Rowling", 2010);
                    LOTR.Statement();
                    Console.ReadKey();
                }
                if (choose == "LOTR2")
                {
                    Book LOTR2 = new Book("V tieni", 304);
                    LOTR2.Statement();
                    Console.ReadKey();
                }
                if (choose == "LOTR3")
                {
                    Book LOTR3 = new Book();
                    LOTR3.Statement();
                    Console.ReadKey();
                }
                if (choose == "HOBIT")
                {
                    Book HOBIT = new Book("Ake drahe je yadaro", 262, "Education", "Dan Arielz", 2020);
                    HOBIT.Statement();
                    Console.ReadKey();
                }
            }
        }

    }
}
