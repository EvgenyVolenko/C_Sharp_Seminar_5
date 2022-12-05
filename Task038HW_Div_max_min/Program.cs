// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int digit;
const int LEFTRANGE = -100;
const int RIGHTRANGE = 100;

Console.Write("Введите длинну массива: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

int[] array = FillArray(digit, LEFTRANGE, RIGHTRANGE);

Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DivArray(array)}");

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