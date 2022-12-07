// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.

int ProductOfNums(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        prod *= i;
    }

    return prod;
}

Console.WriteLine(ProductOfNums(int.Parse(Console.ReadLine())));