// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
/*
Console.WriteLine("Input a number A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B:");
int numberB = Convert.ToInt32(Console.ReadLine());
ToDegree(numberA, numberB);


void ToDegree(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    Console.WriteLine(res);
}/*
// Задача 27 Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
452 -> 11;  82 -> 10;  9012 -> 12   */
/*
Console.WriteLine("Input a number:");
int number = Convert.ToInt32(Console.ReadLine());


int length = Number(number);
SumNumb(number, length);


int Number(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumb(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
*/
/* Задача 29 Напишите программу, которая задаёт массив из N элементов и 
выводит их на экран.
 

Console.WriteLine("Input the length of array:");
int newArray = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[newArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}
*/




