using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Array
{
    class program
    {
        static void Main(string[] args)
        {

            NumberQuery();
            numberLambda();
        }
         
        private static void numberLambda()
        {
            int[] Numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var OutPutNumbers = Numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach(int number in OutPutNumbers )
            {
                Console.WriteLine(number.ToString());

            }
            Console.ReadLine();

        }
        
        private static void NumberQuery()
        {
            int[] Numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };
             var OutPutNumbers = from number in Numbers
                                    where number > 5
                                     orderby number
                                     select number;

            foreach (int number in Numbers)
            {

                Console.WriteLine(number.ToString());
            }

            Console.ReadLine();



        }


    }
}
