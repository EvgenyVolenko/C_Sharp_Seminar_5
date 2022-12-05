// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
int dm = 35;
int[] array = new int[dm];
int[] arrayP = new int[dm / 2];

FillArray(array);
Console.WriteLine($"Массив после заполнения [{string.Join(", ", array)}]");

arrayP = ProizvArray(array, dm / 2);

Console.WriteLine($"Массив заполненный произведениями [{string.Join(", ", arrayP)}]");

void FillArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

int[] ProizvArray(int[] col, int dlinmas)
{
    int[] proizv = new int[dlinmas];
    for (int i = 0; i < col.Length / 2; i++)
    {
        proizv[i] = col[i] * col[col.Length - 1 - i];
    }
    return proizv;
}