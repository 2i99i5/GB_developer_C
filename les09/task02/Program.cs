/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int RecursionNum(int m, int n, int sum = 0)
{
    if (m > n) // проверка, что первое число меньше второго
    {
        int tmp;
        tmp = n;
        n = m;
        m = tmp;
    }
    if (m == n)
    {
        return sum + m;
    }
    sum += m;
    return RecursionNum(m + 1, n, sum);
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");

Console.Write($"{RecursionNum(m, n)}");
