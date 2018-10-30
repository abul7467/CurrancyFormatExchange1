using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Curreny Format Converter! \nPlease enter three dollar amounts to calculate total, average, and lowest/highest number!");

            Console.WriteLine("\nFirst dollar amount: ");
            string num1 = Console.ReadLine();
            double currency1 = double.Parse(num1);

            Console.WriteLine("\nSecond dollar amount: ");
            string num2 = Console.ReadLine();
            double currency2 = double.Parse(num2);

            Console.WriteLine("\nThird dollar amount: ");
            string num3 = Console.ReadLine();
            double currency3 = double.Parse(num3);

            double total = currency1 + currency2 + currency3;

            double average = total / 3;
            average = Math.Round(average, 2);

            Console.WriteLine($"The total of the three dollar amounts is: {total}");
            Console.WriteLine($"The average of the three dollar amounts is: {average}");

            if (currency1 > currency2 && currency1 > currency3)
            {
                Console.WriteLine("The biggest dollar amount is: " + currency1);
            }
            else if (currency2 > currency1 && currency2 > currency3)
            {
                Console.WriteLine("The biggest dollar amount is: " + currency2);
            }
            else if (currency3 > currency1 && currency3 > currency2)
            {
                Console.WriteLine("The biggest dollar amount is: " + currency3);
            }

            if (currency1 < currency2 && currency1 < currency3)
            {
                Console.WriteLine("The smallest dollar amount is: " + currency1);
            }
            else if (currency2 < currency1 && currency2 < currency3)
            {
                Console.WriteLine("The smallest dollar amount is: " + currency2);
            }
            else if (currency3 < currency1 && currency3 < currency2)
            {
                Console.WriteLine("The smallest dollar amount is: " + currency3);
            }
            Console.WriteLine("");
            Console.WriteLine("The total in US currency: ");
            Console.WriteLine(total.ToString("C3", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("The total in Swedish currency: ");
            Console.WriteLine(total.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.WriteLine("The total in Japanese currency: ");
            Console.WriteLine(total.ToString("C3", CultureInfo.CreateSpecificCulture("ja-JP")));
            //Console.WriteLine("The total in Thai currency: ");
            //Console.WriteLine(total.ToString("C3", CultureInfo.CreateSpecificCulture("th-TH")));
            Console.ReadKey();
        }
    }
}