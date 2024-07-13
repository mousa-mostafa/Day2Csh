using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student();
            st1.setdata(4526, 33, "mohamed");
            st2.setdata(1278, 20, "Ahmed");

            st1.getData();
            st1.isGraduated();

            st2.getData();
            st2.isGraduated();
        }
    }
}
