using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter the number: ");
            int aNumber = Convert.ToInt16(Console.ReadLine());

            if (aNumber>=80 && aNumber<100)
            {
                Console.Write("The grade is A+");
            }
            else if (aNumber>=70 && aNumber<80)
            {
                Console.Write("The grade is A");
            }
            else if (aNumber>=60 && aNumber<70)
            {
                Console.Write("The grade is B");
            }
            else if(aNumber>=50 && aNumber<60)
            {
                Console.Write("The grade is C");
            }
            else if (aNumber>=40 && aNumber<50)
            {
                Console.Write("The grade is D");
            }
            else if (aNumber>0 && aNumber<40)
            {
                Console.Write("Sorry. You are Fali");
            }
            else
            {
                Console.Write("Out of range");
            }
            Console.ReadKey();
        }
    }
}
