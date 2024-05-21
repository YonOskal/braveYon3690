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
Console.Write("]");
}

int ArrayToNumber(int[] array)
{
int res = 0;
for (int i = 0; i < array.Length; i++)
{
res = res * 10 + array[i];
}

return res;
}

Console.WriteLine("Задайте размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 1 || n > 8 )
{
Console.WriteLine("Некорректный ввод!");
return;
}

int[] arr = CreateArrayRndInt(n, 0, 10);
PrintArray(arr);

int result = ArrayToNumber(arr);
Console.WriteLine($" => {result}");
