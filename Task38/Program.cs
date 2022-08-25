// Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Random rnd = new Random();
int[] d = new int[30];
int max = 0, min = 100;
for (int i = 0; i < d.Length; i++)  d[i] = rnd.Next(100);
for (int i = 0; i < d.Length; i++)
    {
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
    }      
for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);
Console.WriteLine();
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Разница Max и Min: " + (max - min));