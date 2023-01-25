// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите число строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
CreateArray(m, n);
PrintArray(array);

int[,] CreateArray(int m, int n)
{
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = rnd.Next(-100, 100);
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

System.Console.WriteLine("введите номер строки массива");
int Line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите номер столбца массива");
int Column = Convert.ToInt32(Console.ReadLine())

if (Line < m && Column < n)
    System.Console.WriteLine("заданный элемент массива =" + array[Line - 1, Column - 1]);
else
    System.Console.WriteLine("номер массива выходит за пределы массива");