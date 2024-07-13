using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Book
    {
        int id;
        string name;
        string type;
        String createdon;
        int price;
        static int count = 0;


        public Book(int Id, string Name,string Type,string Createdon, int Price)
        {
            name = Name;
            id = Id;
            type = Type;
            createdon = Createdon;
            price = Price;
            count++;

        }

        public void getDataBook()

        {
            Console.WriteLine($"\nbook details : \n\n ID : {id} \n name : {name} \n Price : {price} \n Type : {type} \n creation date : {createdon}");
        }
        public void howManysells()
        {
            Console.WriteLine("number of sold : "+count);
        }

    }


}
