/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите количество первых N чисел Фибоначчи - ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[arrayLength];

array1[0] = 0;
array1[1] = 1;

for (int i = 2; i < arrayLength; i++)
{
    array1[i] = array1[i - 2] + array1[i - 1];
}

Console.Write($"Первые {arrayLength} чисел Фибоначчи: [");
for (var i = 0; i < array1.Length; i++)
{
    if (i != array1.Length - 1)
    {
        Console.Write(array1[i]);
        Console.Write(", ");
    }
    else
    {
        Console.Write(array1[i]);
    }
}
Console.WriteLine("]");
