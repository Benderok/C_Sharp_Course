// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// int ReadNumber(string message)
// {
//     Console.Write(message);
//     var s = Console.ReadLine();
//     int a = s == null ? 0 : int.Parse(s);
//     return a;
// }

void Cube(int N)
{
   int i = 0;
   double cube;
   while (i < N)
   {
        i += 1;
        if (i == (N))
        {
            cube = Math.Pow(i, 3);
            Console.Write($"{cube}.");
        }
        else
        {
        cube = Math.Pow(i, 3);
        Console.Write($"{cube}, ");
        }
   } 
}

Console.WriteLine("Enter number: ");
int x = int.Parse(Console.ReadLine());
// int x = ReadNumber("Enter number: ");
Cube(x);