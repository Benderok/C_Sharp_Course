// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

int item = int.Parse(Console.ReadLine());

if (item < 100)
{
    Console.WriteLine("Wrong number!");
    return;
}

while (item >= 1000)
{
    item /= 10;
}
Console.WriteLine(item % 10);