// Напишите программу, которая проверяет присутстует ли заданное число в массиве.

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

string Search(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
            return "YES";
    }
    return "NO";
}

Console.WriteLine("Enter Massiv Length and Diapazon: ");
int[] array_a = Massive(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
Console.WriteLine("Enter number you want to search: ");
Console.WriteLine(Search(array_a, int.Parse(Console.ReadLine())));