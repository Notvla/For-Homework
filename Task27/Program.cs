// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
  int SumNumber(int numberN)
  {
    int count = Convert.ToString(numberN).Length;
    int adv = 0;
    int reslt = 0;
    for (int i = 0; i < count; i++)
    {
      adv = numberN - numberN % 10;
      reslt = reslt + (numberN - adv);
      numberN = numberN / 10;
    }
   return reslt;
  }
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр: " + sumNumber);