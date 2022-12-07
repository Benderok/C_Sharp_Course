// Напишите цикл, который принимает на вход 2 числа (А и В) и возводит число
// А в натуральную степень В.

double Power (int A, int B)
{
    double result = 1;
    int modB = Math.Abs(B);
    for (int i = 1; i <= modB; i++)
    {
        if (B > 0)
            result *= A;
        else
            result /= A;
    }
    return result;
}

Console.WriteLine("Enter a number: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a power: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine(Power(A, B));