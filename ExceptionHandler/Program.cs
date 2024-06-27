using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert an index");
            int index = Convert.ToInt32(Console.ReadLine());
            int result = ExceptionManager.GetNumber(index);

            if (ExceptionManager.WrongAnswer)
            {
                Console.WriteLine($"Wrong index");
            }else
            {
                Console.WriteLine($"The sesult is {result}");

            }
            Console.ReadKey();
        }
    }
}
