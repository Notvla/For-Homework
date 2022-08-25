// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[12];
int j = 0, k = 0;
Random rnd = new Random();
Console.WriteLine("Рандомный массив");
for (int i = 0; i < 12; i++)
    {
    arr[i] = rnd.Next(-999, 999);
    Console.Write("{0} ", arr[i]);
    }
Console.WriteLine();
Console.WriteLine("Отсортированный массив ");
Array.Sort(arr);
foreach(int element in arr)
    {
    Console.Write("{0} ", element);
    if (element % 2 == 0)
        {
        j++;
        }
    }
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}", j);
