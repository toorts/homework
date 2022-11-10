//* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//* и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int NumPower(int number, int power)
// {
//     int result = 1;

//     for (int current = 1; current <= power; current++)
//     {
//         result *= number;
//     }

//     return result;
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a power: ");
// int pow = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} to the power of {pow} equals {NumPower(num, pow)}");


//* Задача 27: Напишите программу, которая принимает на вход число
//* и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int DigitSum(int number)
// {
//     int result = 0;
//     int digits = number;

//     while (digits != 0)
//     {
//         result += digits % 10;
//         digits /= 10;
//     }

//     return result;
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum of all digits in {num} is {DigitSum(num)}");


//* Задача 29: Напишите программу, которая задаёт массив из m элементов
//* и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];

//     for (int i = 0; i < size; i++)
//     {   
//         Console.Write($"Input number {i + 1}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
        
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("{ ");

//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.Write("}");
// }

// Console.Write("Input a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();
// int[] numList = CreateArray(num);

// Console.WriteLine();
// ShowArray(numList);
