/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//метод инициализации массива
float [] InitArray(int demension)
{
    float[] arr = new float[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(0,100);
    }
    return arr;
}

//метод, который печатает массив на консоль
void PrintArray(float[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"]");
}

//метод, который находит разность максимального и минимального элементы массива
float GetDiffOfMaxMinElements(float[] array)
{
    float min = array[0];
    float max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if (array[i]<min) min = array[i];
    }
    return max-min;
}

float [] arr = InitArray(5);
PrintArray(arr);
float difMaxMin = GetDiffOfMaxMinElements(arr);
Console.WriteLine($"Разность максимального и минимального = {difMaxMin}");
Console.WriteLine();

float[] array1 = new float[] { 3, 7, 22, 2, 78 };
PrintArray(array1);
Console.WriteLine($"Разность максимального и минимального = {GetDiffOfMaxMinElements(array1)}");
