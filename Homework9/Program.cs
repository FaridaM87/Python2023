/* Task64
Console.WriteLine("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
NumberCount(n, count);
Console.Write(1);

void NumberCount(int n, int count)
{
  if (count > n) return;
  NumberCount(n, count + 1);
  Console.Write(count + ", ");
} 

Task66
Console.WriteLine("Input M number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N number:");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"The sum = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

Task68

Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunc(m,n);



void AkkermanFunc(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
} */