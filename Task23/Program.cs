// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int n = -1;
while (n < 1)
{
Console.WriteLine("Введите число N");
n = Convert.ToInt32(Console.ReadLine());
if ( n < 1) Console.WriteLine("Введены неверные данные");
}

void Square(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"Число - {count} | {count*count*count}");
        count++;
    }

}

Square(n);
