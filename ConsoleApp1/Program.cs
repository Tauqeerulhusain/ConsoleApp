using ConsoleApp1.Models;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 0 };
            var sortedNum = num.OrderBy(x => x).ToArray();
            var firstElement = sortedNum[0];
            foreach (var element in sortedNum)
            {
                if(!sortedNum.Contains(firstElement))
                {

                }
                else
                {

                }
                firstElement++;

            }
        }
    }
}
