using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("MARIA", "19-40343-1", "CSE", 3.39f);
            s.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Book b = new Book("Tin Goenda", "Qazi Anwar Hussain", "2B", "spy-thriller", 30);
            b.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Book b2 = new Book("Treasure Hunter", "Qazi Anwar Hussain", "3B", "spy-thriller", 22);
            b2.ShowInfo();
            Console.WriteLine("----------------------------- ");

            b2.AddBookCopy(10);
            b2.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Account sa = new Account("shaAcc", "sS001", 5000);
            sa.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Account la = new Account("libAcc", "lL002", 25000);
            la.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Library l = new Library("Moyez Uddin Library", " Faridpur", 30000);
            l.ShowLibInfo();
            Console.WriteLine("----------------------------- ");




            l.AddNewBook(b);
            l.AddNewBook(b2);
            l.ShowAllBooks();
            l.AddNewBookCopy(b, 68);
            l.AddNewBookCopy(b2, 87);
            l.ShowAllBooks();

        
    }
    }
}
