// Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

void SmallestSumm(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int max = 1000;
    int summ;
    int smallest = 0;

    for (int i = 0; i < row; i++)
    {   
        summ = 0;
        for (int j = 0; j < column; j++)
            summ += arr[i, j];
        if (max > summ)
        {
            max = summ;
            smallest = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The smallest summ of numbers is in row - {smallest + 1}");
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
SmallestSumm(arr_1);