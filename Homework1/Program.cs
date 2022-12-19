// Задача 3. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

 Console.WriteLine("Input a first number:");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a second number:");
 int num2 = Convert.ToInt32(Console.ReadLine());

 if (num1 > num2)
 {
     Console.Write($"{num1} greater than {num2} ");
 }
 else if (num1 < num2 )
 {
     Console.Write($"{num2} greater than {num1} ");
 }

// Задача 4.  Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.


 Console.WriteLine("Input three numbers: ");
 int numA = Convert.ToInt32(Console.ReadLine());
 int numB = Convert.ToInt32(Console.ReadLine());
 int numC = Convert.ToInt32(Console.ReadLine());

 int max = numA;

 if (numB > max)
 {
     max = numB;
 }
 if (numC > max)
 {
     max = numC;
 }
 Console.WriteLine("The max number is:" + max );

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

   Console.WriteLine("Input a number: ");
   bool number = Convert.ToInt32(Console.ReadLine());

   if (number % 2 == 0)
   {
       Console.WriteLine("Yes!");
   }
   else
   {
       Console.WriteLine("No!");
  }

// Задача 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Input a number");
 int n = Convert.ToInt32(Console.ReadLine());

 int res = 0;

 while (res < n)

 {
    res++;
   if (res % 2 == 0)
    
   {
         Console.WriteLine(res);
         
   }

 }