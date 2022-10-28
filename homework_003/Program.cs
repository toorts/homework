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