/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/

void FillArray(int[] arrayCreate)
{
    Console.WriteLine("Введите числа для заполнения массива:");
    for (int index = 0; index < arrayCreate.Length; index++)
    {
        arrayCreate[index] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
}

void WriteNumber(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write(array[i]);
            Console.Write(", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива - ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[arrayLength];

FillArray(array1);
Console.Write("Введен массив 1 - ");

WriteNumber(array1);

int[] array2 = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    array2[i] = array1[i];
}
Console.WriteLine($"Проведено поэлементное копирование массива 1 в массив 2:");

Console.Write("Вывожу массив 2 - ");
WriteNumber(array2);