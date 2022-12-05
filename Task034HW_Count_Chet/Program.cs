// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int digit;

Console.Write("Введите длинну массива: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

int[] array = new int[digit];

FillArray(array);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

Console.WriteLine($"Количество чётных чисел в массиве = {CountChet(array)}");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int CountChet(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] % 2 == 0) count++;
    }
    return count;
}