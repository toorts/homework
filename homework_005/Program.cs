int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("{ ");

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.Write("}");

    Console.WriteLine();
}

//* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//* Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int NumberOfEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Input a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(num, 100, 999);

// ShowArray(myArray);

// Console.WriteLine($"Number of even elements is {NumberOfEven(myArray)}");


//* Задача 36: Задайте одномерный массив, заполненный случайными числами.
//* Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int SumOddPosition(int[] array)
// {
//     int result = 0;

//     for (int i = 1; i < array.Length; i += 2)
//         result += array[i];

//     return result;
// }

// Console.Write("Input a number of elements: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(num, min, max);

// ShowArray(myArray);

// int counter = SumOddPosition(myArray);

// Console.WriteLine($"Sum of elements in odd positions is {counter}");


//* Задача 38: Задайте массив вещественных чисел. 
//* Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76