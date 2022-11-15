//* Задача 41: Пользователь вводит с клавиатуры M чисел.
//* Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int NumOfPositive(int number)
// {
//     int result = 0;

//     for (int i = 1; i <= number; i++)
//     {
//         Console.Write($"Input number {i}: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n > 0) result++;
//     }

//     return result;
// }

// Console.Write("Input a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Number of positives is {NumOfPositive(num)}");


//* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//* заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Input b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// if (b1 == b2 && k1 == k2)
//     Console.WriteLine("These are the same lines.");

// else if (k1 == k2)
//     Console.WriteLine("These are parallel lines.");

// else
// {
//     double x = Math.Round((b2 - b1) / (k1 - k2), 2);
//     double y = Math.Round(k2 * x + b2, 2);
//     Console.WriteLine($"Point of intersection is ({x}, {y})");
// }
