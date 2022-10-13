/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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
    int count = 1;
    int startI = 0;
    int startJ = 0;
    int endI = m - 1;
    int endJ = n - 1;

    while (count < m * n)
    {
        for (int j = startJ; j < endJ; j++)
        {
            matrix[startI, j] = count;
            count++;
        }
        for (int i = startI; i < endI; i++)
        {
            matrix[i, endJ] = count;
            count++;
        }
        for (int j = endJ; j > startJ; j--)
        {
            matrix[endI, j] = count;
            count++;
        }
        for (int i = endI; i > startI; i--)
        {
            matrix[i, startJ] = count;
            count++;
        }
        startI++;
        startJ++;
        endI--;
        endJ--;
        if (count == m*n)  //для матриц с нечётным числом элементов в стороне
        {
            matrix[startI, startJ] = count;
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
            Console.Write($"{matrix[i, j]:d2} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число m");
int[,] matrix = InitMatrix(m, m);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);