//* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//* и на выходе показывает вторую цифру этого числа.

// int showSecondNum(int number)
// {
//     int cutThird = number / 10;
//     int result = cutThird % 10;

//     return result;
// }

// Console.Write("Input 3-digit number: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Second number of {num} is {showSecondNum(num)}");

//* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//* или сообщает, что третьей цифры нет.

// int ShowThirdNum(int number)
// {
//     if (number > 999)
//     {
//         while (number > 999)
//         {
//             number = number / 10;
//         }
//     }

//     if (number < 1000 && number > 99)
//     {
//         number = number % 10;
//         return number;
//     }

//     else return -1;
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Third number of {num} is {ShowThirdNum(num)}"); 

//* Задача 15: Напишите программу, которая принимает на вход цифру,
//* обозначающую день недели, и проверяет, является ли этот день выходным.

// bool WeekEnd(int day)
// {
//     if (day == 6 || day == 7) return true;
//     else return false;
// }

// Console.Write("Input day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(WeekEnd(num));
