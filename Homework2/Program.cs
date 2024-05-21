// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System.Runtime.CompilerServices;

int[] array = CreateArrayRndInt(50, 100, 999);
int count = CountEvenNum(array);
PrintArray(array);
    
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
   Console.WriteLine($"] {count}");
}

int CountEvenNum (int[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (arr [i] % 2 == 0)
    {count++;}
}
return count;
}
