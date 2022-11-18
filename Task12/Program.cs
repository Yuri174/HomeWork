// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое числа кратныйм второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34,5 --> не кратно, остаток 4
// 16,4 --> кратно
Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());

int Mulitiplicity ( int num1, int num2)
{
    return num1 % num2;
}

int result = Mulitiplicity (num1,num2);
Console.WriteLine(result == 0? "Первое число кратно второму" : $"Нектратно, остаток = {result}");