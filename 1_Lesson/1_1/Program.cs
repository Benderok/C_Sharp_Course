// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадатом второго

Console.WriteLine("Enter number 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number 2");
int num2 = int.Parse(Console.ReadLine());

if(num2 == num1*num1)
{
    Console.WriteLine("Yes");
}

else 
    Console.WriteLine("No");
