// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

 
int[] arr = new int[8]; //[1,0,1,1,0,1,0,0]
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,2);
}
Console.WriteLine(string.Join(", ", arr));