// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.

int SummOfNums(int num)
{
    int summ = 0;
    for (int i = 1; i <= num; i++)
    {
        summ += i;
    }

    return summ;
}

Console.WriteLine(SummOfNums(int.Parse(Console.ReadLine())));