// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Вариант №1  исходные данные по ТЗ


int[,] array = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] ResultAarray = new int[2, 2];
array[0,0] =2; 
array[0,1] =4;
array[1,0] =3;
array[1,1] =2;

array2[0,0] =3;
array2[0,1] =4;
array2[1,0] =3;
array2[1,1] =3;
ResultAarray[0,0] =0;
ResultAarray[0,1] =0;
ResultAarray[1,0] =0;
ResultAarray[1,1] =0;

Console.WriteLine("массив №1");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("массив №2");
PrintArray(array2);
Console.WriteLine();

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
int temp1 = 1;
int MultiplicationArray(int[,] array, int[,] array2, int[,] ResultAarray )
{
     for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
//                          2 4  3 4  2*3+4*3  2*4+4*3
//                          3 2  3 3  3*3+2*3  3*4+2*3 
                for (int s = 0; s < 2; s++)
            ResultAarray[i,j] += (array[i,s] * array2[s,j]);
           temp1 =1;
        }

        }
       return temp1;
}
MultiplicationArray(array, array2,ResultAarray );

Console.WriteLine("итог");
PrintArray(ResultAarray);


// Вариант №2

// Console.WriteLine("Введите число строк массиввов");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов массивов");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// array = CreateArray(m, n);
// Console.WriteLine("массив №1");
// PrintArray(array);
// Console.WriteLine();
// int[,] array2 = new int[m, n];
// array2 = CreateArray(m, n);
// Console.WriteLine("массив №2");
// PrintArray(array2);
// Console.WriteLine();
// int[,] ResultAarray = new int[m, n];

// int[,] CreateArray(int m, int n)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//             array[i, j] = rnd.Next(0, 4);
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiplicationArray(int[,] array, int[,] array2, int[,] ResultAarray )
// {
//      for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//                 for (int s = 0; s < 2; s++)
//             ResultAarray[i,j]+= (array[i,s] * array2[s,j]);
//         }
//         }
//        }
// MultiplicationArray(array, array2, ResultAarray);
// Console.WriteLine("итог");
// PrintArray(ResultAarray);

