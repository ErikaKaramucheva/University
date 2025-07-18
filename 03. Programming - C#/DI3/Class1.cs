using System;
using System.Collections.Generic;
using System.Text;

namespace DI3
{
    class Book
    {
        private string name;
        private string authorName;
        private int year;
        private double price;
        private int pages;

        public Book(string name, string authorName, int year,double price,int pages)
        {
            this.name = name;
            this.authorName = authorName;
            this.year = year;
            this.price = price;
            this.pages = pages;

        }

        public string Name { get { return name; } set { name = value; } }
        public string AuthorName { get { return authorName; } set { authorName = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int Pages { get { return pages; } set { pages = value; } }

        public override string ToString()
        {
            return "Book name: "+name+". Author name: "+authorName+". Year: "+year+". Price: "+price+". Pages: "+pages;
        }
    }
}
