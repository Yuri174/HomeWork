// Напишите программу, которая принимает на выход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14-->нет 
// 46-->нет
// 161-->да
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Mulitiplicity(num) ? "Да" : "Нет");

bool Mulitiplicity(int num)
{
    return (num % 7 ==0) && (num % 23 == 0);
}


