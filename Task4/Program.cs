// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// Console.Write("Введите целое число: ");
// string input = Console.ReadLine;
// while (true)
// {
//     if (num == "q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }
//     Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n > 0)
//         {
//             Console.WriteLine("Некоректный ввод");
//             return;
//         }
// }




while (true)
{
    Console.Write("Введите целое число: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        Console.WriteLine("Программа завершена.");
        break;
    }

    if (int.TryParse(input, out int n))
    {
        if (n < 0)
        {
            Console.WriteLine("Некорректный ввод");
            continue;
        }

        if (IsSumOfDigitsEven(n))
        {
            Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}


static bool IsSumOfDigitsEven(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum % 2 == 0;
}


