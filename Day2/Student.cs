using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
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
}
