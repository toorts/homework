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


//* Задача 54: Задайте двумерный массив. Напишите программу, 
//* которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void BubbleSort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//             for (int k = j + 1; k < array.GetLength(1); k++)
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temp;
//                 }
// }

// Console.Write("Input a number of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] my2DArray = CreateRandom2DArray(r, c, min, max);
// Show2DArray(my2DArray);

// BubbleSort(my2DArray);
// Show2DArray(my2DArray);


//* Задача 56: Задайте прямоугольный двумерный массив.
//* Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[] CreateRowSumArray(int[,] array)
// {
//     int[] rowSumArray = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//             sum += array[i, j];

//         rowSumArray[i] = sum;
//     }

//     return rowSumArray;
// }

// int GetMinRow(int[] array)
// {
//     int min = 0;

//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < array[min]) min = i;

//     return min;
// }

// Console.Write("Input a number of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] my2DArray = CreateRandom2DArray(r, c, min, max);
// Show2DArray(my2DArray);

// int[] sumsArray = CreateRowSumArray(my2DArray);
// int minRow = GetMinRow(sumsArray);

// Console.WriteLine($"Number of row with min sum of elements is {minRow + 1}");


//* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

//     if (arrayA.GetLength(1) == arrayB.GetLength(0))
//     {
//         for (int i = 0; i < arrayA.GetLength(0); i++)
//             for (int j = 0; j < arrayB.GetLength(1); j++)
//                 for (int k = 0; k < arrayA.GetLength(1); k++)
//                     arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
//     }

//     return arrayC;
// }

// Console.Write("Input a number of rows in Matrix A: ");
// int rA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns in Matrix A: ");
// int cA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a number of rows in Matrix B: ");
// int rB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns in Matrix B: ");
// int cB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxB = Convert.ToInt32(Console.ReadLine());

// int[,] matrixA = CreateRandom2DArray(rA, cA, minA, maxA);
// Show2DArray(matrixA);

// int[,] matrixB = CreateRandom2DArray(rB, cB, minB, maxB);
// Show2DArray(matrixB);

// int[,] matrixC = MatrixMultiplication(matrixA, matrixB);
// Show2DArray(matrixC);







//*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//*Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


//*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

