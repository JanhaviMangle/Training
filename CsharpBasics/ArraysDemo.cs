using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ArraysDemo
    {
        static void Main()
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;

            foreach (var item in evenNums)
                Console.WriteLine(item);

            foreach (var city in cities)
                Console.WriteLine(city);
            Console.WriteLine("*******************");
            Array.Sort(nums);
            foreach (var i in nums)
                Console.WriteLine(i);



            Array.Sort(nums); // sorts array
            Console.WriteLine("*******************");
            Array.Reverse(nums); // sorts array in descending order

            foreach (var i in nums)
                
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search 
            Console.ReadLine();
        }
    }
}
