// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
//является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру :");

int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник");
    Console.WriteLine ("Не выходной");
}
 else if (number ==2)
{  
    Console.WriteLine("Вторник");
   Console.WriteLine ("Не выходной"); 
}
else if (number==3)
{
    Console.WriteLine("Среда");
    Console.WriteLine ("Не выходной");
}
else if (number ==4)
{
    Console.WriteLine("Четверг");
    Console.WriteLine ("Не выходной");
}
else if (number ==5)
{
    Console.WriteLine("Пятница");
    Console.WriteLine ("Не выходной");
}
else if (number ==6)
{
    Console.WriteLine("Суббота");
    Console.WriteLine ("Выходной");
}
else if (number ==7)
{
    Console.WriteLine("Воскресенье");
    Console.WriteLine ("Выходной");
}

    