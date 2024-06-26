using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            AudioBook book1 = new AudioBook("book1", "author1", "narrator1");
            book1.PrintInfo();

            PdfBook book2 = new PdfBook("book2", "author2", "publisher1");
            book2.Price = 10.2;
            book2.PrintInfo();
            book2.PrintInfo(book2.Publisher , book2.Price);

            Console.ReadKey();
        }
    }
    public class Book
    {
        public string Name;
        public string Author;

        public virtual void PrintInfo()
        {
            Console.WriteLine(Name + " " + Author);
        }
    }
    public class AudioBook : Book
    {
        public string Narrator;

        public AudioBook(string name, string author, string narrator)
        {
            Name = name;
            Author = author;
            Narrator = narrator;
        }
        public override void PrintInfo()
        {
            Console.WriteLine( Name + " " + Author + "(" + Narrator + ")");
        }
    }

    public class PdfBook : Book {
        public string Publisher;
        public double Price;

        public PdfBook (string name, string author, string publisher) { 
            Name = name;
            Author= author;
            Publisher = publisher;
        }

        public void PrintInfo(string publisher, double price)
        {
            Console.WriteLine(Name + " " + Author + " " + publisher + " " + price + "$");
        }
    }
}
