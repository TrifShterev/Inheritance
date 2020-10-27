using System;
using System.Collections.Generic;

namespace CustomStack
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new StackOfStrings();
            stack.AddRange(new List<string> { "Gosho", "Pesho", "TOSHO" });
            Console.WriteLine(string.Join(" ",stack));

            foreach (var item in stack)
            {
                Console.WriteLine(item);

            }
        }
    }
}
