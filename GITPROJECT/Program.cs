
using System;

namespace EnkelKalkylator
{

    class program

    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Enkel kalkylator");
            Console.WriteLine("Ange operation (+, -m, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine("\nAnge första talet:");
            double num1 =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ange andra talet:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;   
                    break;
                case '*':
                    result = num1 * num2;   
                    break;  
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("ogiltig operation");
                    return;


            }
         
            Console.WriteLine($"Resultat: {result}");
            Console.ReadKey();
                    
        }
    }
}