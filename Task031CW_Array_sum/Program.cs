// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
const int SIZE = 12; // const изменить нельзя
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] array = FillArray(SIZE, LEFTRANGE, RIGHTRANGE);

Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

(int sumP, int sumN) = GetSumPositiveAndNegative(array);

Console.WriteLine($"Сумма положительных чисел = {sumP}, сумма отрицательных чисел = {sumN}");

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

(int, int) GetSumPositiveAndNegative(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    return (sumPositive, sumNegative);
}