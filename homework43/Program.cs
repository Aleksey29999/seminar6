// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Вариант 1 без функций

// Console.WriteLine("введите k1");
// double k1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("введите b1");
// double b1 = Convert.ToInt32(Console.ReadLine ());

// Console.WriteLine("введите k2");
// double k2 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("введите b2");
// double b2 = Convert.ToInt32(Console.ReadLine ());

// double x = (b2-b1) / (k1-k2);
// double y = k1 * (b2-b1) / (k1-k2) + b1;

// Console.WriteLine( x);
// Console.WriteLine( y);

// Вариант 2 

(double k, double b) GetTwoNumber (string message)
{
    Console.WriteLine("введите b и k");
    Console.WriteLine();
    double b = Convert.ToInt32(Console.ReadLine());
    double k = Convert.ToInt32(Console.ReadLine());
    return (k,b);
}
(double k1, double b1) = GetTwoNumber ("введите первых два числа");
(double k2, double b2) = GetTwoNumber ("введите вторых два числа");
 double x = (b2-b1) / (k1-k2);
 double y = k1 * (b2-b1) / (k1-k2) + b1;
 Console.WriteLine("х=" + x);
 Console.WriteLine("y=" + y);