//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру обозначающую день недели");

int dayNum = Convert.ToInt32(Console.ReadLine());

void Checking (int dayNum){

    if (dayNum ==6 || dayNum ==7)
    {
    Console.WriteLine("Выходной день");
    }

    else if (dayNum < 6)
{
Console.WriteLine("Не выходной день");
} 
}

Checking(dayNum);

