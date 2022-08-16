// Напишите программу, которая принимает на вход координаты двух точек,
// и находит расстояние между ними в 3D пространстве.
// X(3,6,8); Y(2,1,-7), -> 15.84
// X(7,-5, 0); Y(1,-1,9) -> 11.53

Console.WriteLine("Введите координату X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X3: ");
double X3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y3: ");
double Y3 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(Y1-X1, 2) + Math.Pow(Y2 - X2, 2) + (Math.Pow(Y3 - X3,2)));
Console.WriteLine(length);