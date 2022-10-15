using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            switch (number)
            {

                case 5:
                    Console.WriteLine(number);
                    Console.ReadLine();
                    break;
                case 10:
                    Console.WriteLine(number + 1);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(number + 999);
                    Console.ReadLine();
                    break;


            }
        }
    }
}