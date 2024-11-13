using System;
using System.Text;
using System.Linq;

namespace NumberExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с цифрами:");
            string input = Console.ReadLine();

            string digitsOnly = new string(input.Where(char.IsDigit).ToArray());
            Console.WriteLine("Извлеченные цифры: " + digitsOnly);

           
            int sum = digitsOnly.Select(d => int.Parse(d.ToString())).Sum();

            string sumString = sum.ToString();

            string result = input + " " + sumString;
            Console.WriteLine("Результат: " + result);
        }
    }
}
