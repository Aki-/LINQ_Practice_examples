using System;

namespace Linq_practice_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice routine 1
            
            //Problem: WAP to print even number from int array of 10
            //Write in Both styles: 1. QUERY Expression   2. Method Syntax.



            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //var evenNum = from x in nums
            //              where (x % 2) == 0
            //              select x;

            //foreach(int i in evenNum)
            //Console.WriteLine(i);




            //IEnumerable<int> sumNums = nums.Where(x => (x % 2) == 0);
            //foreach (int i in sumNums)
            //    Console.WriteLine(i);



            Console.Read();




        }
    }
}
