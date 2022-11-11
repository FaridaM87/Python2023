// Напишите программу, которая принимает 
// 1. на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.WriteLine("введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int res = 0;
int NumDigit(int N) {

while (N > 0)
{
int num = N % 10;
N = N / 10;
res = res + num;
}
return res; 
}
int sum = NumDigit (Num);
Console.WriteLine("сумма всех цифр в числе равна: " + sum);