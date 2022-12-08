// 

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

int CountRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}

Console.WriteLine("Enter Massiv Length and Diapazon: ");
int[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
Console.WriteLine("Numbers in diapazon 10-99: ");
Console.WriteLine(CountRange(array_a));