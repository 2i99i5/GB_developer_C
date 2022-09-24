/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
string WeekEnd (int dayNum)
{
    if (dayNum >= 1 && dayNum <= 5) return "нет";
    else if (dayNum >= 6 && dayNum <= 7) return "да";
    return "Введено что-то отличное от цифры из диапазона от 1 до 7";
}


Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNum = int.Parse(Console.ReadLine()??"");

Console.Write($"Это выходной день? - {WeekEnd (dayNum)}");
