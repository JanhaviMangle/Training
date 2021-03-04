using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    /* Ternary operator are a substitute for if...else statement.

     Syntax : Condition ? Expression1 : Expression2;
    */
    class TernaryDemo
    {
        static void Main()
        {
            int number = 2;
            bool isEven;
            String a;

            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);

            a = (number % 2 == 0) ? "Even Number" :
                "OddNumber";
            Console.WriteLine(a);

            int n1 = 20, n2 = 30;
            String b;
            b = n1 > n2 ?
                "N1 is greater than N2" : 
                n1 < n2 ? "N2 is greater than N1" :
                "N1 is equal to N2";
            Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
