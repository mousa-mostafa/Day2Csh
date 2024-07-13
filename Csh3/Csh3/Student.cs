using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csh3
{
    class Student
    {

        static Student()
        {
            Console.WriteLine("hello");
        }
        public Student(int ID, int Age, String Name)

        {
            Console.WriteLine($"Name : {Name}\n ID : {ID} \n Age : {Age}\n");
        }
    }
    }
