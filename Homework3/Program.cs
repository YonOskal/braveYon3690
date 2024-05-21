// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = CreateArrayRndInt(10, 1, 10);
Console.WriteLine("Исходный массив:");
PrintArray(array); // Вывод исходного массива

array = ReverseArray(array); // Переворачиваем массив
Console.WriteLine("\nПеревернутый массив:");
PrintArray(array); // Вывод перевернутого массива

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

int[] ReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = array[array.Length - 1 - i];
    }
    return reversedArray;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]\n");
}
