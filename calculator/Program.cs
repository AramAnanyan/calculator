using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b, sum;
            char x;
            a = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToChar(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            switch (x)
            {
                case '+':
                    sum = a + b;
                    Console.WriteLine(sum);
                    break;
                case '-':
                    sum = a - b;
                    Console.WriteLine(sum);
                    break;
                case '*':
                    sum = a * b;
                    Console.WriteLine(sum);
                    break;
                case '/':
                    sum = a + b;
                    Console.WriteLine(sum);
                    break;
                default:
                    Console.WriteLine("wrong symbol "+ "'"+ x +"'");
                    break;

            }
            
        }
    }
}
