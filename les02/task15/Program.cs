/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNum = int.Parse(Console.ReadLine()??"");

Console.Write("Это выходной день? ");
if (dayNum >= 1 && dayNum <= 5) Console.WriteLine("нет");
else if (dayNum >= 6 && dayNum <= 7) Console.WriteLine("да");
else Console.WriteLine("Введено что-то отличное от цифры из диапазона от 1 до 7");
