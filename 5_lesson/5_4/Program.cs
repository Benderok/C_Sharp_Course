// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] PairsNum(int[] array)
{
    int size = array.Length;
    int flex_size = size / 2 + size % 2;
    int [] new_array = new int [flex_size];

    for (int i = 0; i < size / 2; i++)
        new_array[i] = array[i] * array[size - i -1];

    if (new_array[flex_size - 1] == 0)
        new_array[flex_size - 1] = array[flex_size -1];
    return new_array;
}

Console.WriteLine("Enter Massiv Length and Diapazon: ");
int[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
int[] array_a_new = PairsNum(array_a);
PrintMassiv(array_a_new);