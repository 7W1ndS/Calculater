using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            string str2;

            str = Console.ReadLine();

            int a = Convert.ToInt32(str);

            Console.WriteLine("Введите +, -, *, /.");

            string str1 = Console.ReadLine();

            switch(str1)
            {
                case "+":

                    str2 = Console.ReadLine();

                    int b = Convert.ToInt32(str2);

                    int result = a + b;

                    Console.WriteLine(result);

                    break;
                    
                case "-":

                    str2 = Console.ReadLine();

                    int c = Convert.ToInt32(str2);

                    int result1 = a - c;

                    Console.WriteLine(result1);

                    break;

                case "*":

                    str2 = Console.ReadLine();

                    int d = Convert.ToInt32(str2);

                    int result2 = a + d;

                    Console.WriteLine(result2);

                    break;

                case "/":

                    str2 = Console.ReadLine();

                    int f = Convert.ToInt32(str2);

                    int result3 = a / f;

                    Console.WriteLine(result3);

                    break;

                default:

                    Console.WriteLine("Введено недопустимое значение!");

                    break;



            }
        }
    }
}
