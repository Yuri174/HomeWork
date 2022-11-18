




Console.WriteLine("Введите кординаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты точки");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quater (int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}

int quater = Quater(x,y);
string result = quater > 0 
        ? $"Указанные кординаты соответствуют четверти ->{quater}"
        : "Введены некорректные кординаты";
        Console.WriteLine(result);
