// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] array = new int[25];

Console.WriteLine($"Первоначальный массив [{string.Join(", ", array)}]");

FillArray(array);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

SortArray(array);
Console.WriteLine($"Массив после замены [{string.Join(", ", array)}]");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void SortArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = 0 - col[i];
    }
}
