// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

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