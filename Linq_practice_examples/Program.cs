using System;

using System.Collections.Generic;
using System.Linq;

namespace Linq_practice_examples
{
    class Program
    {
        static void Main(string[] args)
        {


            //printEvenNums();
            getNumberWithSquare();





            Console.Read();

        }



        public static void printEvenNums()
        {
            //Practice routine 1

            //Problem: WAP to print even number from int array of 10
            //Write in Both styles: 1. QUERY Expression   2. Method Syntax.



            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            var evenNum = from x in nums
                          where (x % 2) == 0
                          select x;

            foreach (int i in evenNum)
                Console.WriteLine(i);

            IEnumerable<int> sumNums = nums.Where(x => (x % 2) == 0);
            foreach (int i in sumNums)
                Console.WriteLine(i);
        }

        public static void getNumberWithSquare()
        {
            //Find the number and its square of an array which is more than 20

            //Expected Output : 
            //{ Number = 9, SqrNo = 81 } 
            //{ Number = 8, SqrNo = 64 }            

            //{ Number = 3, SqrNo = NA } SHOULD NOT PRINT ANYTHING



            int[] arr1 = new[] { 3, 9, 2, 8, 6, 5 };


            var numberWithSquare = from int n in arr1
                                   let sqNum = n * n
                                   where sqNum > 20
                                   select new { n, sqNum };


            foreach(var v in numberWithSquare)
                Console.WriteLine(v);


            Console.Read();



        }











    }
}
