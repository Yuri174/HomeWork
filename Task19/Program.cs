// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (true)
break;

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Не верное число!");
}
else
{
    bool Palindrome()
    {
        int numLeft1 = num / 10000;
        int numRight1 = num % 10;
        int numLeft2 = num / 1000 % 10;
        int numRight2 = num / 1000 % 10;
        return(numLeft1 == numRight1 && numLeft2 == numRight2);
    }
    Console.WriteLine(Palindrome()? $"{num} -> да" : $"{num} -> нет");
}
    