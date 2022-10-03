/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//метод инициализации массива
int [] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

//метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"]");
}

//метод, который считает четные числа в массиве
int GetCountOfEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count += 1;
    }
    return count;
}

int [] arr = InitArray(4);
PrintArray(arr);

int positiveCount = GetCountOfEvenElements(arr);

Console.WriteLine($"Количество чётных элементов = {positiveCount}");
