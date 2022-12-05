// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

Console.Clear();
int[] array = new int[10];
int digit;

Console.Write("Введите число: ");

while (true)
{
    if (int.TryParse(Console.ReadLine(), out digit)) break;
    else Console.Write("Ну просил же ЧИСЛО: ");
}

FillArray(array);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

if (FindArray(array, digit) == true) Console.WriteLine("ДА, число присутствует в массиве!");
else Console.WriteLine("НЕТ, числа нет в массиве!");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

bool FindArray(int[] col, int n)
{
    bool check = false;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] == n) 
        {
            check = true;
            break;
        }         
    }
    return check;
}