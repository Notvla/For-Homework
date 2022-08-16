// Напишите программу, которая принимает на вход число (N), 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любое число N: ");
double N = Convert.ToInt32(Console.ReadLine());
double count = 0;
while(count <= N)
{
Console.WriteLine(Math.Pow((count), 3)); 
count++;
}
Console.Write("↑↑↑ Заданное число в кубе");