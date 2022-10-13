/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
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

int[,] MultiplicationOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); ++i)
        for (int j = 0; j < matrix2.GetLength(0); ++j)
            for (int k = 0; k < matrix2.GetLength(1); ++k)
                result[i, k] += matrix1[i, j] * matrix2[j, k];
    return result;
}

int m = GetNumber("Введите число m1");
int n = GetNumber("Введите число n1");
int[,] matrix1 = InitMatrix(m, n);
m = GetNumber("Введите число m2");
n = GetNumber("Введите число n2");
int[,] matrix2 = InitMatrix(m, n);

Console.WriteLine("Матрица1:");
PrintMatrix(matrix1);
Console.WriteLine("");
Console.WriteLine("Матрица2:");
PrintMatrix(matrix2);

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    int[,] result = MultiplicationOfMatrix(matrix1, matrix2);
    Console.WriteLine("Произведение матриц");
    PrintMatrix(result);
}
Console.WriteLine("");

int[,] ar1 = { { 2, 4 }, { 3, 2 } };
int[,] ar2 = { { 3, 4 }, { 3, 3 } };
Console.WriteLine("Матрица1:");
PrintMatrix(ar1);
Console.WriteLine("Матрица2:");
PrintMatrix(ar2);

Console.WriteLine("Произведение матриц");
PrintMatrix(MultiplicationOfMatrix(ar1, ar2));