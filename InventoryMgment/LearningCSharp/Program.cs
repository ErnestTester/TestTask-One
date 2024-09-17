using LearningCSharp.workingWithList;
using System;

namespace LearningCSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Code in Main");
            List1 lst = new List1();

            lst.DisplayList();


            Console.WriteLine("Add a new item to the list...");
            lst.DisplayList();


        }
    }
}