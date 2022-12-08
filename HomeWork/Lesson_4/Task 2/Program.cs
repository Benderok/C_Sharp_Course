// Напишите программу, которая принимает на вход число и
// выдает сумму цифр в числе.

int SummOfDigits(int x)
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

// Variant -------- 2

double DigitSum(int num)
{
    string n = num.ToString();
    int length = n.Length;
    double sum = 0;

    for (int i = 0; i < length; i++)
    {
        double m = char.GetNumericValue(n[i]);
        sum += m;
    }
    return sum;
}

Console.WriteLine(DigitSum(int.Parse(Console.ReadLine())));