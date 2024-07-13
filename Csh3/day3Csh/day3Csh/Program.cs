using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Student
{
    int ID;
    int Age;
    String Name;

    public void setData(int id, int age, string name) {
        id = ID;
        age = Age;
        name = Name;

    };
    public void getData()
    {
        Console.WriteLine($"Name : {Name} ID : {ID} \n Age : {Age}");

    }
    public void check()
    {
        
        if (Age >= 60)
        {
            Console.WriteLine("retired");

        }
        else Console.WriteLine("retired");


    }

}

namespace day3Csh
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st1 = new Student();
            Student st2 = new Student();
            st1.setData(1523, 85, "ahmed");
            st1.setData(4526, 33, "mohamed");

            st1.getData();
            st1.check();
            st2.check();
        }

    }
}
