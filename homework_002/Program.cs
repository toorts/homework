//* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//* и на выходе показывает вторую цифру этого числа.

// int ShowSecondDigit(int number)
// {
//     int cutThird = number / 10;
//     int result = cutThird % 10;

//     return result;
// }

// Console.Write("Input 3-digit number: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Second digit of number {num} is {ShowSecondDigit(num)}");


//* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//* или сообщает, что третьей цифры нет.

// int ShowThirdDigit(int number)
// {
//     if (number > 999)
//     {
//         while (number > 999)
//         {
//             number = number / 10;
//         }
//     }

//     if (number > 99 && number < 1000)
//     {
//         int result = number % 10;
//         return result;
//     }

//     else return -1;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (ShowThirdDigit(num) == -1)
//     Console.WriteLine($"There is no third digit in number {num}!");
// else
//     Console.WriteLine($"Third digit of number {num} is {ShowThirdDigit(num)}");


//* Задача 15: Напишите программу, которая принимает на вход цифру,
//* обозначающую день недели, и проверяет, является ли этот день выходным.

// bool WeekEnd(int day)
// {
//     if (day == 6 || day == 7) return true;
//     else return false;
// }

// Console.Write("Input day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (WeekEnd(num))
//     Console.WriteLine("It's a WeekEnd day!");
// else
//     Console.WriteLine("It's a work day");
