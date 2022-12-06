// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom (int num)
{
     int a;
     int b;
     int c;
     int d;
     b = num % 10;
     a = num / 10000;
     c = num / 10 % 10;
     d = num / 1000 % 10;
     
if (a == b || d == c) Console.WriteLine($"{num} -> Palindrom");

else Console.WriteLine($"{num} -> Not Palindrom!");
}

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
Palindrom(N);


// Console.WriteLine("Enter number: ");
// int N = int.Parse(Console.ReadLine());
// int b = N % 10;
// int a = N / 10000;
// int c = N / 10 % 10;
// int d = N / 1000 % 10;

// if (a == b || d == c)
// {
//     Console.WriteLine($"{N} ->Palindrom");
// }
// else
// {
//     Console.WriteLine($"{N} -> Not Palindrom!");
// }