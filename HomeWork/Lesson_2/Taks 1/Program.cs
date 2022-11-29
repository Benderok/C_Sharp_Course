// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.

String SecondDigit(int number)
{
    Console.WriteLine(number);
    if (number < 100 || number > 999)
        return "Not 3 digit";

    else
        number /= 10;
        number %= 10;
        return $"Second digit -> {number}";
}

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(SecondDigit(number));