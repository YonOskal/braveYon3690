// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.Write("Введите целое число: ");
//             string input = Console.ReadLine();

//             if (input == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             if (!int.TryParse(input, out int n) || n < 0)
//             {
//                 Console.WriteLine("Некорректный ввод. Введите положительное целое число или 'q' для выхода.");
//                 continue;
//             }

//             if (IsSumOfDigitsEven(n))
//             {
//                 Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
//                 break; // Завершает программу, если сумма цифр чётная
//             }
//             else
//             {
//                 Console.WriteLine("Сумма цифр числа нечётная.");
//             }
//         }
//     }

//     static bool IsSumOfDigitsEven(int n)
//     {
//         int sum = 0;
//         while (n > 0)
//         {
//             sum += n % 10;
//             n /= 10;
//         }
//         return sum % 2 == 0;
//     }
// }

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число (или 'q' для выхода): ");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            bool isNumber = true;
            int sum = 0;
            foreach (char c in input)
            {
                if (c >= '0' && c <= '9')
                {
                    sum += c - '0';
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число или 'q' для выхода.");
                    isNumber = false;
                    break;
                }
            }

            if (!isNumber)
            {
                continue;
            }

            if (sum % 2 == 0)
            {
                Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
                break;
            }
        }
    }
}

