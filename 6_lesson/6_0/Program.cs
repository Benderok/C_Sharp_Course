// Напишите программу, которая перевернет одномерный массив.

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

void RevMas(int[] array_a)
{
    int size = array_a.Length;

    for (int i = 0; i < size / 2; i++)
        (array_a[i], array_a[size - i - 1]) = (array_a[size - i - 1], array_a[i]);
}

int[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
RevMas(array_a);
PrintMassiv(array_a);