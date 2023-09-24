/* 
Задача 43: Напишите программу,
которая найдёт точку пересечения двух прямых,
заданных уравнениями:
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 */

double ConsoleReading(string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine()!);
    return number;
}

(double, double) FindIntersection(double b1, double k1, double b2, double k2)
{
    // Проверяем, что прямые не параллельны
    if (k1 == k2)
    {

        Console.WriteLine("Прямые параллельны и не пересекаются");
        return (-1, -1);
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        return (x, y);
    }
}

double b1 = ConsoleReading("Введите значение b1: ");
double k1 = ConsoleReading("Введите значение k1: ");
double b2 = ConsoleReading("Введите значение b1: ");
double k2 = ConsoleReading("Введите значение k1: ");
(double, double) point = FindIntersection(b1, k1, b2, k2);

if (point != (-1, -1))
{
    Console.WriteLine("Точка пересечения двух прямых имеет координаты ({0}, {1})", point.Item1, point.Item2);
}