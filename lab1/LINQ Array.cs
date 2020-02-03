using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class LINQ_Array
    {
        static void Main(string[] args)
        {

            //NumberQuery();
            //numberLambda();
        }
         
        private static void NumberLambda()
        {
            int[] Numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var OutPutNumbers = Numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach(int number in OutPutNumbers )
            {
                Console.WriteLine(number.ToString());

            }
            Console.ReadLine();

        }
        



    }
}
