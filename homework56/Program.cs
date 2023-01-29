// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.WriteLine("Введите число строк массиввов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массивов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
array = CreateArray(m, n);
Console.WriteLine("массив №1");
PrintArray(array);
Console.WriteLine();

int[] array2 = new int[m];
array2 = CreateArray2(m);
int[] CreateArray2(int m)
{
    for (int i = 0; i < m; i++)
    {
        array2[i] = 0;
    }
    return array2;
}

int[,] CreateArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = rnd.Next(0, 10);
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int temp2 = 0;
int SummArray2(int[] array2, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array2[i] += array[i, j];
            temp2 = 1;
        }
    }
    return temp2;
}

void PrintArray2(int[] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            Console.Write(array2[i] + " ");
        }
        Console.WriteLine();
    }
}
SummArray2(array2, array);
Console.WriteLine("массив №2");
PrintArray2(array2);

int NumberRows = 0;
int min = array2[0];
for (int i = 0; i < array2.Length; i++)
{
    if (min > array2[i])
    {
        min = array2[i];
    NumberRows = i;
    }
  }
Console.WriteLine(" строка с минимальной суммой=" + NumberRows );