using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjecttt
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1; int num1 = 0; int num2 = 0;
            while (true)
            {

                Console.WriteLine("Enter First Num");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Num");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose the arithmetic operation:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");


                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"The result is: {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"The result is: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"The result is: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"The result is: {num1} / {num2} = " + (num1 / num2));
                        break;
                }

                Console.WriteLine("do you want to contunue:T/F");
                string option = Console.ReadLine();
                if (option.ToUpper() == "F")
                {
                    break;
                }

            }


            Console.ReadKey();


        }
    }
}
