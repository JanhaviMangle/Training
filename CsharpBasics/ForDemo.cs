using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ForDemo
    {
        public static void Main(string[] args)
        { 
            for(int i=1;i<=5;i++)
        {
            Console.WriteLine("C# For Loop: Iteration {0}", i);
        }

        //multiple initialization & iterator expression

        for(int i=0,j=0; i+j<=5; i++,j++)
            {
            Console.WriteLine("i = {0} and j {1}",i,j);
            }
    //for loop without initialization & iterator statement

    int m = 1;
    for(; m<=5)
        {
        Console.WriteLine("C# For Loop: Iteration {0}", m);
        m++;
        }
for(; ; )
{
    Console.WriteLine("infinite loop");
}


    }

