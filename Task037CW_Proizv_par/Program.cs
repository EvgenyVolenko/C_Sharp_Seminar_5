// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
const int SIZE = 15; 
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int[] array = FillArray(SIZE, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

int[] arrayP = ProizvArray(array);

Console.WriteLine($"Массив заполненный произведениями и непарным числом[{string.Join(", ", arrayP)}]");

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

int[] ProizvArray(int[] col)
{
    int[] proizv = new int[col.Length / 2 + col.Length % 2];

    for (int i = 0; i < col.Length / 2; i++)
        {
            proizv[i] = col[i] * col[col.Length - 1 - i];
        }

    if (col.Length % 2 != 0)
    {
        proizv[proizv.Length - 1] = col[col.Length / 2];
    }
    return proizv;
}