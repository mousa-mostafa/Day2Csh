using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Class
class Student
{
    public int ssn;
    public string name;
    public int age;
    public string phone;

    public void print()
    {
        Console.WriteLine($" ssn : {ssn} \n Name : {name} \n Age : {age} \n Phone : {phone} ");
    }
}
#endregion
namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region do while

            //Console.WriteLine("Enter ID :");
            //int ID = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter name :");
            //string name = Console.ReadLine();

            //int age = 0;
            //do
            //{
            //    Console.WriteLine("Enter age :");
            //    age = int.Parse(Console.ReadLine());

            //} while (age <= 0);
            //Console.WriteLine("name is : " + name);
            //Console.WriteLine("id is : " + ID);
            //Console.WriteLine("age is : " + age);

            #endregion

            #region instance

            Student std1 = new Student();
            std1.ssn = 2652515;
            std1.name = "mousa";
            std1.age = 20;
            std1.phone = "0122222";
            std1.print();
            #endregion

        }
    }
}
