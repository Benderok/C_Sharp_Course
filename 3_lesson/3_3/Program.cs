// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

void Chet(int N)
{
   int i = 0;
   double square;
   while (i < N )
   {
        i += 1;
        if (i == (N))
        {
            square = Math.Pow(i,2);
            Console.Write($"{square}.");
        }
        else
        {
        square = Math.Pow(i,2);
        Console.Write($"{square}, ");
        }
   } 
}
Console.WriteLine("Enter number: ");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);