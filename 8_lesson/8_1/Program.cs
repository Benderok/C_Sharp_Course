// 2. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

void ChangeUp(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i,j],arr[j,i]) = (arr[j,i],arr[i,j]);
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Замена невозможна");
    }

}