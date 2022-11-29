// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

String ThirdDigit(int item)
{
    if (item < 100)
    return "Wrong number!";

    while (item >= 1000)
    item /= 10;

item %= 10;
return item.ToString();
}

int item = ReadNumber("Enter number: ");
Console.WriteLine(ThirdDigit(item));

//int item = int.Parse(Console.ReadLine());
//
//if (item < 100)
//{
//    Console.WriteLine("Wrong number!");
//    return;
//}
//
//while (item >= 1000)
//{
//    item /= 10;
//}
//Console.WriteLine(item % 10);