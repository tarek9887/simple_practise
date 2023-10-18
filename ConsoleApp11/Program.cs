using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            for (int i = 0; i < firstString.Length; i++)
            {
                if (secondString[0] == firstString[i])
                {
                    count = i + 1;
                    break;

                }
            }
            if (count == 0)
            {
                Console.WriteLine("Does not contain the alphabet");
            }
            else
            {
                Console.WriteLine(count);
            }
            Console.ReadLine();
        }
    }
}
