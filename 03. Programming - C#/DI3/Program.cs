

using System;
using System.Collections.Generic;
using System.Linq;

namespace DI3
{
    class Program
    {
        static void Main(string[] args)
        {
            //sled 2015 i s cena nad srednata
            Book b1 = new Book("The Midnight Library", "Mat Haig", 2018, 26.50, 340);
            Book b4 = new Book("The Midnight Library", "Mat Haig", 2018, 26.50, 340);
            Book b2 = new Book("Love", "Elif Shafak", 2009, 19.90, 384);
            Book b3 = new Book("Autumn", "Ali Smith", 2018, 18.00,240);
            List<Book> books = new List<Book> { b1, b2, b3 ,b4};

            var result = findBook(books);
            foreach(Book b in result)
            {
                Console.WriteLine(b.ToString());
            }
        }

        public static IEnumerable<Book> findBook(List<Book> books)
        {
            double averagePrice = 0;
            foreach(Book b in books)
            {
                averagePrice += b.Price;
            }
            averagePrice /= books.Count;
            return books.Where(x => x.Year >= 2015 && x.Price > averagePrice);
        }
    }
}
