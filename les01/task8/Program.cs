﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int i = 2;

Console.Write("Чётные числа от 1 до N: ");
while (i < n + 1)
{
    Console.Write($"{i}, ");
    i = i + 2;
}
