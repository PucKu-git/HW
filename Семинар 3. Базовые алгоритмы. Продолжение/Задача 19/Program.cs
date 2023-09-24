/*
Задача 19: Напишите программу,
которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да
*/
using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      // Проверяем, является ли число пятизначным
      if (number < 10000 || number >= 100000)
      {
        // Выводим сообщение об ошибке с помощью интерполяции строк
        Console.WriteLine($"Число не пятизначное");
        return false; // выходим из метода
      }

      // Получаем цифры числа с помощью арифметических операторов
      int firstDigit = number / 10000;
      int secondDigit = (number / 1000) % 10;
      int fourthDigit = (number / 10) % 10;
      int fifthDigit = number % 10;
      
      // Проверяем, не равны ли первая и пятая цифры или вторая и четвертая цифры
      if (firstDigit != fifthDigit || secondDigit != fourthDigit)
      {
        return false; // это не палиндром
      }
      
      // Если мы дошли до этого места, значит все цифры равны
      return true; // это палиндром
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}