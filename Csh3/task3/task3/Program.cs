using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book(8524, "book", "learning"," 2/10/1996", 50);
            Book b2 = new Book(1455, "food", "eating", " 5/7/2002", 75);
            Book b3 = new Book(9514, "football", "sports", " 7/3/2013", 85);
            Book b4 = new Book(3274, "C#", "programming", " 1/7/2009", 89);


            b1.getDataBook();
            b4.getDataBook();
            b1.howManysells();


        }
    }
}
