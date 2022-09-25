/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[] MakeArray(int len)
{
    double[] nums = new double[len];
    int i = 0;
    while (i < len)
    {
        nums[i] = Math.Pow(i + 1, 3);
        i++;
    }
    return nums;
}

int number = ReadData("Введите число N: ");

Console.WriteLine("{0}", string.Join(", ", MakeArray(number)));
