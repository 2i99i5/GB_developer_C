/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Pow (int a, int b)
{
    int aPowB = a;
    for (int i=1; i<b; i++)
    {
        aPowB *= a;
    }
    return aPowB;
}

Console.WriteLine($"Введите число a");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"Введите число b");
int b = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A={a} в степени B={b} равно {Pow(a,b)}");