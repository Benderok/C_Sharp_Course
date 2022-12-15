// Копирование двумерного массива.

void PrintMassiv(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
                Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }
}

int[,] FillMassiv(int row, int column)
{
    int [,] array = new int [row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        array[i, j] = new Random().Next(1, 100);
    return array;
}

int[,] Clone(int[,] array_1)
{
    int row = array_1.GetLength(0);
    int column = array_1.GetLength(1);
    int[,] new_array = new int [row, column];
for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            new_array[i, j] = array_1[i, j];
    }
    return new_array;
}

Console.WriteLine("Enter Massiv Rows and Coll: ");
int[,] array_a = FillMassiv(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMassiv(array_a);
int[,] array_b = Clone(array_a);
Console.WriteLine();
PrintMassiv(array_b);