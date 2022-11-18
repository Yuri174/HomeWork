// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число ");

int num = Convert.ToInt32(Console.ReadLine());

int RemoveSecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}
Console.WriteLine("Вторая цифра трехзначного числа");
Console.WriteLine($"Результат = {RemoveSecondDigit(num)}");
