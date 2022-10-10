// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetVar(string varName)
// Метод запрашивает число
{
    Console.Write($"Введите параметр {varName}: ");
    double number = double.Parse(Console.ReadLine() ?? "");
    return number;
}

void IntersectionCoordinate()
// метод выводит на экран координаты точки пересечения
{
    double b1 = GetVar("b1");
    double k1 = GetVar("k1");
    double b2 = GetVar("b2");
    double k2 = GetVar("k2");
    Console.WriteLine($"Координаты точки пересечения прямых y = {k1}*x + {b1}, y = {k2}*x + {b2}");
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"({x}; {y})");
}

IntersectionCoordinate();