// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
/*
Console.WriteLine("Input a five-digit number:");
int number = int.Parse(Console.ReadLine()!);
void PolindromeNum(int number)
{
if (number >= 10000)
{
    int num1 = number / 10000;
    int res1 = number % 10;
    if(num1 == res1)
    {
       number = number / 10;
       int num2 = (number / 100) % 10;
       int res2 = number % 10;
       if (num2 == res2) 
          Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine( "False");
    }
}
else
{
    Console.WriteLine("Wrong number! ");
}
}
PolindromeNum(number);
*/


// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
/*
int x1 = ReadInt("Input the X coordinate of the first point: ");
int y1 = ReadInt("Input the Y coordinate of the first point: ");
int z1 = ReadInt("Input the Z coordinate of the first point: ");
int x2 = ReadInt("Input the X coordinate of the second point: ");
int y2 = ReadInt("Input the Y coordinate of the second point: ");
int z2 = ReadInt("Input the Z coordinate of the second point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"The distance is: {length}");


 int ReadInt(string message)
 {
     Console.Write(message);
     return Convert.ToInt32(Console.ReadLine());
 }
*/
Console.WriteLine("Input a number N:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}




 



