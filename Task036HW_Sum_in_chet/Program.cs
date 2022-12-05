// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {SumArray(array)}");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

int SumArray(int[] col)
{
    int sum = 0;
    for (int i = 1; i < col.Length; i++)
    {
        if (i % 2 == 1) sum += col[i];
    }
    return sum;
}