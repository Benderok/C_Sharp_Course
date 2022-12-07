// Напишите программу, которая задает массив из 8 элементов и выводит на экран.

int[] Massive (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintMassiv (int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array_a = Massive(int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
