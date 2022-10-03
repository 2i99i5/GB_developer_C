/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//метод инициализации массива
int [] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-99,100);
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

//метод, который суммирует элементы на нечётных позициях
int GetSummOfOddPositionElements(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        summ += array[i];
    }
    return summ;
}

int [] arr = InitArray(4);
PrintArray(arr);

int oddEl = GetSummOfOddPositionElements(arr);

Console.WriteLine($"Сумма элементов на нечётных позициях = {oddEl}");