using System;
using System.Collections.Generic;

namespace _01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> nums = new List<int>() { 1, 2, 3 };
            nums.Add(1);
            nums.Add(12);
        }
    }
}
