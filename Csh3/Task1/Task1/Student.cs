using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student
    {
        int id;
        int age;
        string name;

        public void setdata(int ID,int Age,string Name)
        {
            id = ID;
            age = Age;
            name = Name;

        }
        public void getData()
        {
            Console.WriteLine($"Name : {name}\n ID : {id} \n Age : {age}");

        }
        public void isGraduated()
        {
            if (age >= 24){
                Console.WriteLine("Graduated \n");
            }
            else Console.WriteLine("not Graduated \n");


        }
    }

}
