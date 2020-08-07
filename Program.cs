using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08072020EqualityAndAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // assignment operator
            //int x, y;
            //x = 5;
            //y = x;

            // equality operator == "is equal to"
            //int x, y;
            //x = 5;
            //y = 3;

            // Console.WriteLine(x == y);

            // object 1
            Person p1 = new Person();
            p1.Name = "Chuck";

            // object 2
            // Person p2 = new Person();
            // p2.Name = "Chuck";

            Person p2 = p1;

            // memery address
            Console.WriteLine(p1 == p2);
            Console.ReadLine();
        }
    }
}