/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int Akkerman(int n, int m)
{
  if (n == 0) return m + 1;
  else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
    else return Akkerman(n - 1, Akkerman(n, m - 1));
}

int m = GetNumber("Введите число m:");
int n = GetNumber("Введите число n:");

Console.Write($"{Akkerman(m, n)}");