﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782-->72
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число = {number}");

int RemoveSecondDigit(int numb)
{
    int firstDigit = numb / 100;
    int thirdDigit = numb % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
Console.WriteLine("Удаляем вторую цифру числа");
Console.WriteLine($"Результат = {RemoveSecondDigit(number)}");
