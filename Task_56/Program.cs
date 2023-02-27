/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.
*/

int[,] InitMatrix()
{
    int[,] array = new int[4, 3];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

void GetMinSumRow(int[,] matr)
{
    int minRow = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minRow = i + 1;
        }
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow}");
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
Console.WriteLine();
GetMinSumRow(matrix);