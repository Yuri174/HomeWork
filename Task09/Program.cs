﻿//Напишите программу которая выдает случайное двухзначное число и указывает наибольшее число из них.
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 --> {number}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
