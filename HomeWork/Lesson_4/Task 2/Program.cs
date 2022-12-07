// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе.

int SummOfDigits (int x)
{
    int result = 0;
    while (x > 0)
    {
        result += x % 10;
        x /= 10;
    }
    return result;
}

Console.WriteLine("Enter number");
Console.WriteLine(SummOfDigits(int.Parse(Console.ReadLine())));