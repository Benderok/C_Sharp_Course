// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int PosAmmount ()
{
    int count = 0;
    string word;

    Console.WriteLine("Input numbers: ");
    while (true)
    {
        word = Console.ReadLine();

        if (word == "")
        {
            Console.Write($"Ammount of Positie numbers: ");
            return count;
        }
        else if (int.Parse(word) > 0) count++;
    }
}

Console.WriteLine(PosAmmount());