// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите ряд чисел, разделенных запятой  : ");
int Numbers = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[Numbers];

// for (int i = 0; i < Numbers; i++)
// {
//     array[i] = new Random().Next(Numbers+1);
//     Console.Write(array[i] + "; ");
// }


int[] arr = Console.ReadLine()
                .Split(' ', ',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
Console.WriteLine(string.Join(", ", arr));

            
         

