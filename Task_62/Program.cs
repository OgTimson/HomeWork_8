/*
Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] InitSpiralMatrix()
{
    int[,] arr = new int[4, 4];
    int num = 1;
    int rowStart = 0, rowEnd = arr.GetLength(0) - 1;
    int colStart = 0, colEnd = arr.GetLength(1) - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            arr[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            arr[i, colEnd] = num++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                arr[rowEnd, i] = num++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                arr[i, colStart] = num++;
            }
            colStart++;
        }
    }

    return arr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }

        Console.WriteLine();
    }
}

int[,] matrix = InitSpiralMatrix();
PrintMatrix(matrix);