// Напишите программу, котрая 
// 1 .принимает на вход координаты точки (X и Y),
// 2. причем Х = 0 и Y =0 и 
// 3. выдает тномер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int Y = Convert.ToInt32(Console.ReadLine());

int Quarter(int xc, int yc)
{
    if(xc > 0 && yc > 0)return 1;
    if(xc < 0 && yc > 0) return 2;
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}
int quarter = Quarter(X , Y);
string result = quarter > 0 
           ?  $"Указанные координаты соответствуют четверти -> {quarter}"
           : "Введены некорректные координаты";

Console.WriteLine(result);
