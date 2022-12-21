// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixProduct(int[,] arr_one, int[,] arr_two)
{
    int row = arr_one.GetLength(0);
    int column = arr_one.GetLength(1);
    int[,] prodMatrix = new int[row, column];

    if (row != arr_two.GetLength(0) || column != arr_two.GetLength(1)) return prodMatrix;
    
    for (int i = 0; i < row; i++)       
        for (int j = 0; j < column; j++)
            prodMatrix[i, j] = arr_one[i, j] * arr_two[i, j];            
    return prodMatrix;
}

Console.Write("Enter the number of 1 matrix rows: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of 1 matrix columns: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number of 2 matrix rows: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of 2 matrix columns: ");
int column_2 = int.Parse(Console.ReadLine());

Console.Write("Enter diapason of 1 matrix: ");
int[,] arr_1 = MassNums(row_1, column_1,
                         int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()));

Console.Write("Enter diapason of 2 matrix: ");
int[,] arr_2 = MassNums(row_2, column_2,
                         int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()));
Print(arr_1);
Print(arr_2);

Console.WriteLine("Product of matrix 1 and 2: ");
int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);