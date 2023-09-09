/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine()!);


if (first > second && first > third)
{
     Console.WriteLine("Первое число (" + first + ") - максимальное");
}
else if (second > third)
{
    Console.WriteLine("Второе число (" + second + ") - максимальное");
}
else
{
    Console.WriteLine("Третье число (" + third + ") - максимальное");
}