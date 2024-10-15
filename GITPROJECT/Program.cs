using System;

namespace EnkelKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enkel kalkylator");
                Console.WriteLine("Ange operation (+, -, *, /): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine("\nAnge första talet:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ange andra talet:");
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
                        if (num2 == 0)
                        {
                            Console.WriteLine("Fel: Division med noll är inte tillåten.");
                            return;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Ogiltig operation.");
                        return;
                }

                Console.WriteLine($"Resultat: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fel: Du måste ange ett giltigt tal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett oväntat fel inträffade: {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
