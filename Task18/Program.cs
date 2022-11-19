// Напишите программу которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти(x и y).

Console.WriteLine("Укажите номер четверти");

string quater = Console.ReadLine();

string Range(string quater1)
{
    if(quater1 =="1") return "x > 0  y > 0";
    if(quater1 =="2") return "x < 0  y > 0";
    if(quater1 =="3") return "x < 0  y < 0";
    if(quater1 =="4") return "x > 0  y < 0";
    return "Введены некоректные данные";
}

string range = Range(quater);
Console.WriteLine(range);


