int[,] CreateRandom2DArray(int rows, int cols, int minValue, int maxValue)
{
    int[,] array = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(minValue, maxValue);

    return array;
}

void Show2DArray(int[,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


//* Задача 47. Задайте двумерный массив размером m×n,
//* заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandomDouble2DArray(int rows, int cols, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, cols];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(minValue, maxValue), 1);

//     return array;
// }

// void ShowDouble2DArray(double[,] array)
// {
//     Console.WriteLine();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
// }

// Console.Write("Input a number of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myDouble2D = CreateRandomDouble2DArray(r, c, min, max);
// ShowDouble2DArray(myDouble2D);


//* Задача 50. Напишите программу, которая на вход принимает позиции
//* элемента в двумерном массиве, и возвращает значение этого элемента
//* или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// void FindElement(int[,] array, int row, int col)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (row == i && col == j)
//                 Console.WriteLine($"Element is {array[i, j]}");
//         }
// }

// Console.Write("Input a number of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine();

// Console.Write("Input a row: ");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a column: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] my2DArray = CreateRandom2DArray(r, c, min, max);
// Show2DArray(my2DArray);

// FindElement(my2DArray, line, column);


//* Задача 52. Задайте двумерный массив из целых чисел.
//* Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.