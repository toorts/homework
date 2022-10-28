//* Задача 19. Напишите программу, которая принимает на вход пятизначное число
//* и проверяет, является ли оно палиндромом.

// bool IsPalindrome(int number)
// {
//     int firstDigit = number / 10000;
//     int secondDigit = number / 1000 % 10;
//     int fourthDigit = number / 10 % 10;
//     int fifthDigit = number % 10;

//     if (firstDigit == fifthDigit && secondDigit == fourthDigit)
//         return true;
//     else
//         return false;
// }

// Console.Write("Input 5-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (IsPalindrome(num))
//     Console.WriteLine($"Number {num} is palindrome");
// else
//     Console.WriteLine($"Number {num} is not palindrome");


//* Задача 21. Напишите программу, которая принимает на вход координаты двух точек
//* и находит расстояние между ними в 3D пространстве.

// double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double x = x2 - x1;
//     double y = y2 - y1;
//     double z = z2 - z1;

//     double result = Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));

//     return result;
// }

// Console.Write("Input coordinats x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input coordinats y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input coordinats z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input coordinats x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input coordinats y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input coordinats z2: ");
// double z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Distance between points is {Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2)}");
