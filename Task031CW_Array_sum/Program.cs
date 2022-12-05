// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
int sPol = 0;
int[] array = new int[12];

Console.WriteLine($"Первоначальный массив [{string.Join(", ", array)}]");
FillArray(array);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");
bool plmin = true;
Console.WriteLine($"Сумма положительных чисел = {SortArray(array, sPol, plmin)}");
plmin = false;
Console.WriteLine($"Сумма отрицательных чисел = {SortArray(array, sPol, plmin)}");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

int SortArray(int[] col, int sum, bool pm)
{
    if (pm == true)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (col[i] > 0) sum = sum + col[i];
        }
    }
    else if (pm == false)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (col[i] < 0) sum = sum + col[i];
        }
    }
    return sum;
}