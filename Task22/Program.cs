// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
//5-> 1,4,9,16,25.
//2->1,4

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
        Console.WriteLine($"Число - {count} и его квадрат {count*count}");
        count++;
    }

}

Square(n);

