// Задайте массив из 12 элементов, заполненный случайными числами.
// Найдите сумму отрицательных и положительных элементов массива.

int[] Massive(int size, int from, int to)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(from, to);
    }
    return array;
}

void PrintMassiv(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, Negative: {neg}");
}

int[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
SumPosNeg(array_a);