// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DivArray(array)}");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
}

int DivArray(int[] col)
{
    int min = col[0], max = col[0], div = 0;
    for (int i = 1; i < col.Length; i++)
    {
        if (col[i] > max) max = col[i];
        else if (col[i] < min) min = col[i];
    }
    div = max - min;
    return div;
}