// Напишите программу, которая меняет положительные элементы массива
// на отрицательные и наоборот.

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

void Inversion(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = -arr[i];
}


Console.WriteLine("Enter Massiv Length and Diapazon: ");
int[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
Inversion(array_a);
Console.WriteLine("Inverted Massiv: ");
PrintMassiv(array_a);