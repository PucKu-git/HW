/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int ConsoleReading (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

bool NuberCheck (int number)
{
    return number >= 100 && number <= 999;
}

void FindSecondNumber (int N)
{
    if (NuberCheck(N))
    {
        int secondNumber = (N / 10) % 10;
        Console.WriteLine("Вторая цифра числа " + N + " равна " + secondNumber);
    }
    else
    {
        Console.WriteLine("Число должно быть трехзначным!");
    }
}

int n = ConsoleReading("Ввидите трехзначное число: ");
FindSecondNumber(n);