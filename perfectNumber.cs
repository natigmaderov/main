using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Give A Value For Number \n Number : ");
            int number = Int32.Parse(Console.ReadLine());
            int sum = 0;
            bool check = false;
        
            var list = new List<int>();

            if ( number > 0)
            {
                for (int i = 1; number >i; i++)
                {
                    if( number % i == 0)
                    {
                        list.Add(i);
                       
                        sum += i;
                        if (number == sum)
                        {
                            check = true;
                        }
                        

                    }
                }
                if (check)
                {
                    Console.WriteLine("it is Perfect Number" + " Sum of divisors: " + sum);

                    list.ForEach((x) => Console.Write(x + " "));

                }
                else
                {
                    Console.WriteLine("it is not Perfect Number" + " Sum of divisors:" + sum);


                }

            }
            else
            {
                Console.WriteLine("Perfect number cant be negative");
            }
            Console.ReadKey();
        }
        void listofDivisors()
        {

        }
    }


}
