//Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int x11, int y11, int z11, int x21, int y21, int z21)
{

int rangeX = x2 - x1;
int rangeY = y2 - y1;
int rangeZ = z1 - z2;
double rangeA = Math.Sqrt(rangeX*rangeX+ rangeY*rangeY+rangeZ*rangeZ);
return rangeA;

}
double result = Range(x1, y1, z1, x2, y1, z2);

Console.WriteLine($"{(x2-x1)^2 + (y2-y1)^2 + (z2-z1)^2}");
