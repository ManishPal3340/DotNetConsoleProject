using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)  // "arg" ko "args" kiya aur string[] add kiya
        {
            while (true)
            {
                Console.Clear();  // Screen saaf karega har baar
                Console.WriteLine("======== Arithmetic Operations =========");
                Console.WriteLine("1. User se numbers daal ke calculate karo");
                Console.WriteLine("2. Fixed numbers (10 aur 20) se calculate karo");
                Console.WriteLine("3. Program band karo");
                Console.Write("\nApna choice daaliye (1, 2 ya 3): ");

                string choice = Console.ReadLine();  // User ne jo type kiya woh string mein aayega

                if (choice == "1")  // "1" (string) compare kar rahe hain, '1' (char) nahi
                {
                    Console.Write("Pehla number daaliye: ");
                    double a = double.Parse(Console.ReadLine());

                    Console.Write("Dusra number daaliye: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nResults:");
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    Console.WriteLine($"{a} * {b} = {a * b}");

                    if (b != 0)
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    else
                        Console.WriteLine("Error: Zero se divide nahi kar sakte!");

                    if (b != 0)
                        Console.WriteLine($"{a} % {b} = {a % b}");
                    else
                        Console.WriteLine("Error: Zero se modulus nahi kar sakte!");
                }
                else if (choice == "2")
                {
                    double x = 10;
                    double y = 20;

                    Console.WriteLine("\nFixed numbers: 10 aur 20\n");
                    Console.WriteLine($"10 + 20 = {x + y}");
                    Console.WriteLine($"10 - 20 = {x - y}");
                    Console.WriteLine($"10 * 20 = {x * y}");
                    Console.WriteLine($"10 / 20 = {x / y}");
                    Console.WriteLine($"10 % 20 = {x % y}");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Bye Bye! Program band ho raha hai...");
                    break;  // Loop se bahar nikal jaayega
                }
                else
                {
                    Console.WriteLine("Galat choice! Sirf 1, 2 ya 3 daaliye.");
                }

                Console.WriteLine("\nMenu pe wapas jaane ke liye Enter dabaaiye...");
                Console.ReadLine();  // Yahan rukega jab tak user Enter na dabaaye
            }
        }
    }
}