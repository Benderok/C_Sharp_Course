// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Enter day number: ");
char week = char.Parse(Console.ReadLine());
switch (week)
{
    case '1':
    Console.WriteLine("No");
    break;
    case '2':
    Console.WriteLine("No");
    break;
    case '3':
    Console.WriteLine("No");
    break;
    case '4':
    Console.WriteLine("No");
    break;
    case '5':
    Console.WriteLine("No");
    break;
    case '6':
    Console.WriteLine("Yes");
    break;
    case '7':
    Console.WriteLine("Yes");
    break;
    default:
    Console.WriteLine("Not a day number");
    break;
}

//void Weekend(int num)
//{
//    string text = "Not a weekend";
//
//    if (num == 6 || num == 7) text = "Weekend";
//    Console.WriteLine($"{num} -> {text}");
//}
//Console.WriteLine("Enter day number: ");
//Weekend(int.Parse(Console.ReadLine()));