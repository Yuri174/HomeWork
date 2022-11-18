// Напишите программу, которая выводит третью цифру заданного числа и сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");

int num = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(num);
if(stringNum.Length > 2)
{
    Console.WriteLine("третья цифра этого числа -> "+stringNum[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}



