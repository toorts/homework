//*Задача 64: Задайте значение N. Напишите программу, которая выведет все
//* натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNums(int n)
// {
//     Console.Write(n + " ");
//     if (n > 1) ShowNums(n - 1);   
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowNums(num);



//* Задача 66: Задайте значения M и N. Напишите программу,
//* которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumOfElements(int m, int n)
// {
//     if (m > n)
//         return SumOfElements(m, n + 1) + n;

//     else if (n > m)
//         return SumOfElements(m + 1, n) + m;

//     else
//         return m;
// }

// Console.Write("Input a first number: ");
// int numM = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a second number: ");
// int numN = Convert.ToInt32(Console.ReadLine());

// int sum = SumOfElements(numM, numN);
// Console.WriteLine($"Sum of elements is {sum}");


//* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//* Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int WilhelmFriedrich(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m != 0) && (n == 0))
        return WilhelmFriedrich(m - 1, 1);

    else
        return WilhelmFriedrich(m - 1, WilhelmFriedrich(m, n - 1));
}

Console.Write("Input a first number: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int numN = Convert.ToInt32(Console.ReadLine());

int Ackermann = WilhelmFriedrich(numM, numN);   // sooorry for big A :)
Console.WriteLine($"A({numM},{numN}) = {Ackermann}");  // and thanks for your lessons! 
