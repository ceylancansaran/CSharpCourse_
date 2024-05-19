using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Value Types
            char character = 'C';
            bool condition = true;
            decimal number6 = 10.4m;
            double number5 = 10.4;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            var number7 = 10;
            number7 = 'A';
            //number7 = "A"; ilk başta değişkene int değer atadığımız için string bir değer atamamıza izin vermez.
            
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Condition is {0}", condition);
            Console.WriteLine("Character is {0}", (int)character);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Sunday, Saturday, 
    }
}
