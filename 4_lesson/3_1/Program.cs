// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.

int NumCount(int n)
{
    int count = 0;
    if (n == 0) return 1;
    while (n > 0)
    {
        n /= 10;
        count++;
    }
    return count;
}

Console.WriteLine(NumCount(int.Parse(Console.ReadLine())));