// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

double[] Massive(int size, int from, int to)
{
    double[] array = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    }
    return array;
}

void PrintMassiv(double[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        else if (min > array[i])
            min = array[i];
    }
    Console.WriteLine($"Max: {max}, Min: {min}");
    Console.WriteLine($"{max} - ({min}) = {Math.Round(max - min, 2)}");
}

Console.WriteLine("Enter Massiv Length and Diapazon: ");
double[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
DiffMaxMin(array_a);