using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvanNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 4, 7, 8, 9 };//Declerd array
            int evenNums = 0;

            foreach (int num in numbers)//Declard num so we use it in a foreach loop.
            {
             Console.WriteLine(num);
                    if(num % 2 == 0)
                {
                    evenNums++;
                }
                
            }
        }
    }
}
