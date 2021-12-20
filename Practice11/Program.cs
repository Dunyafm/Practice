using System;
using System.Collections.Generic;

namespace Practice
{
   public class Program
   {
        static void Main(string[] args)
        {
            MyList<int> nums = new MyList<int>();
            List<int> newNums = new List<int>();
            newNums.Add(88);
            newNums.Add(89);
            nums.AddRange(newNums);


            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(8);
            nums.Add(9);
            nums.Add(10);
            nums.Add(11);
            nums.Clear();

            var result = nums.Find(m => m == 88);
            Console.WriteLine(result);

           




        }
   }
}
