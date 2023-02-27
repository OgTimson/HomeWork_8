/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] InitMatrix()
{
    int[,] array = new int[2, 2];

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

    Console.WriteLine();
}

int[,] GetResultMatr(int[,] matrOne, int[,] matrTwo)
{
    int[,] resultMatr = new int[matrOne.GetLength(0), matrTwo.GetLength(1)];

    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            for (int k = 0; k < matrOne.GetLength(1); k++)
            {
                resultMatr[i, j] += matrOne[i, k] * matrTwo[k, j];
            }
        }
    }

    return resultMatr;
}

int[,] matrixOne = InitMatrix();
Console.WriteLine("Первая матрица:");
PrintMatrix(matrixOne);
int[,] matrixTwo = InitMatrix();
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrixTwo);
int[,] resultMatr = GetResultMatr(matrixOne, matrixTwo);
Console.WriteLine("Результирующая матрица после умножения:");
PrintMatrix(resultMatr);