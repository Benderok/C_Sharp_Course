// Напишите прорамму, которая принимает на вход 3 числа и проверят,
// может ли существовать треугольник со сторонами такой длины.

void Triangle()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if (a < b + c & b < a + c & c < a + b)
    Console.WriteLine("Yes");
    else Console.WriteLine("NO");
}
Triangle();