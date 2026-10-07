/* 
Author: Eremei Mironov
Date: 10/6/2026
Assignment: PA2
*/
namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("");
            #region Task2 Part 1

            int maxValue = int.MaxValue;

            Console.WriteLine($"Int Max Value: {maxValue}");
            Console.WriteLine($"Int Max Value (Hex): {maxValue:X}");

            maxValue++;
            Console.WriteLine($"\nAfter Incrementing by 1:");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value (Hex): {maxValue:X}");

            maxValue = 0;
            Console.WriteLine($"\nSet to 0:");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value (Hex): {maxValue:X}");

            maxValue--;
            Console.WriteLine($"\nAfter Decrementing by 1:");
            Console.WriteLine($"Int Value: {maxValue}");
            Console.WriteLine($"Int Value (Hex): {maxValue:X}");

            #endregion

            #region Casting

            int intValue = int.MaxValue;

            short shortValue = (short)intValue;

            Console.WriteLine($"Int Max Value: {intValue}");
            Console.WriteLine($"Int Max Value (Hex): {intValue:X}");

            Console.WriteLine($"Short Value after casting: {shortValue}");
            Console.WriteLine($"Short Value (Hex): {shortValue:X}");

            #endregion
            Console.WriteLine("");
            #region Loops

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("Array values:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            #endregion

            #region Loop Bonus

            Console.WriteLine("\nMultiplication Table (1 to 5):");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i * j}\t");
                }

                Console.WriteLine();
            }

            #endregion
            Console.WriteLine("");
            #region Printer troubleshooter

            string condition = "";

            Console.WriteLine("Does the printer print? (Y/N)");
            string answer1 = Console.ReadLine();
            condition += answer1.ToUpper() == "Y" ? "Y" : "N";

            Console.WriteLine("Is a red light flashing? (Y/N)");
            string answer2 = Console.ReadLine();
            condition += answer2.ToUpper() == "Y" ? "Y" : "N";

            Console.WriteLine("Is the printer recognized by the computer? (Y/N)");
            string answer3 = Console.ReadLine();
            condition += answer3.ToUpper() == "Y" ? "Y" : "N";

            switch (condition)
            {
                case "NYN":
                    Console.WriteLine("Check the printer-computer cable.");
                    Console.WriteLine("Ensure printer software is installed.");
                    Console.WriteLine("Check/replace ink.");
                    break;

                case "NYY":
                    Console.WriteLine("Check/replace ink.");
                    Console.WriteLine("Check for paper jam.");
                    break;

                case "NNN":
                    Console.WriteLine("Check the power cable.");
                    Console.WriteLine("Check the printer-computer cable.");
                    Console.WriteLine("Ensure printer software is installed.");
                    break;

                case "NNY":
                    Console.WriteLine("Check for paper jam.");
                    break;

                case "YYN":
                    Console.WriteLine("Ensure printer software is installed.");
                    break;

                case "YYY":
                    Console.WriteLine("Check/replace ink.");
                    break;

                case "YNN":
                    Console.WriteLine("Ensure printer software is installed.");
                    break;

                case "YNY":
                    Console.WriteLine("No action needed.");
                    break;
            }

            #endregion
        }
    }
}
