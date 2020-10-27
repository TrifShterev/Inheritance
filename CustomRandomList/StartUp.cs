using System;

namespace CustomRandomList
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var list = new RandomList { "Gosho", "PESHO","Misho","TOSHO"};
            Console.WriteLine(list.RandomString());
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
