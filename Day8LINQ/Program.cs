using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello There!");
            var nums = new List<int> { 12,1,5, 2, 3,89, 4, 5, 0, 6, 7,11, 8, 19, 10 };

            int fNum = nums.First();
            int gNum = nums.Last();
            Console.WriteLine($"First Number In List : {fNum}");
            Console.WriteLine($"Last Number In List : {gNum}");

            ////////////////////////////////////////////////////

            //Wheeeeeeeeeeere Test
            IEnumerable<int> filteredNumbers = nums.Where(n => n > 3);
            // Not Working ! Why ?
            //Console.WriteLine($"Filtereeeed  Numbers Greater Than 3 : {filteredNumbers}");
            Console.WriteLine("Filtered Numbers umbers Greater Than 3:");
            foreach (int number in filteredNumbers)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            ///////////////////////////////////////////////////
            // Show First Threeeeee Eleemnts in list:
            IEnumerable<int> takenNumbers = nums.Take(3);
            Console.WriteLine($"Taken First 3 Numbers :");
            foreach (int number in takenNumbers)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            ////////////////////////////////////////
            ///
            //Orderingeeeeeeeeeeee:
            Console.WriteLine($"Ordered List ::");

            IEnumerable<int> orDNums = nums.OrderBy(n => n);
            foreach(int number in orDNums)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();







            var oddNumbers = nums.Where(n => n % 2 != 0);


            // Print the odd numbers.
            Console.WriteLine("Odd Number :");

            foreach (int number in oddNumbers)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            var evenNums = nums.Where(n => n % 2 == 0);
            ////////////////////////////////////
            // Print the odd numbers.
            Console.WriteLine("Even Number :");

            foreach (int number in evenNums)
            {
                Console.Write($"{number} , ");
            }
            Console.WriteLine();

            #region NotWorking
            //Console.WriteLine($"List After Ordering : \n {orDNums}");
            //foreach (int number in orDNums)
            //{
            //    Console.Write($"{number},");
            //}
            //////////////////////
            ///
            #endregion


            #region 1
            ////Select and Process:
            //IEnumerable<bool> isEvenNum=nums.Select(nums=> nums%2==0);
            ////Console.WriteLine($"EvenNums : {isEvenNum}");
            //Console.WriteLine();
            //Console.WriteLine("Even Number :");
            //foreach (bool number in isEvenNum)
            //{
            //    if (number)
            //    {
            //        Console.Write($"{number.ToString()},");
            //    }
            //}
            //Console.WriteLine();
            #endregion


            //IEnumerable<bool> isOdd = nums.Select(nums => nums % 2 != 0);
            ////Console.WriteLine($"EvenNums : {isOdd}");
            //Console.WriteLine("Odd Number :");

            //foreach (bool number in isOdd)
            //{
            //    if (number)
            //    {
            //        Console.Write($"{number},");
            //    }
            //}


            //Teeeeeeest Wheree whith Taek:
            var evenNumbers = nums.Where(n => n % 2 == 0).Take(3);
            Console.WriteLine($"Take With Where (First 3 Even Numbers) : :"); 
            foreach (int number in evenNumbers)
            {
                Console.Write($"{number} , ");
            }





        }
    }
}