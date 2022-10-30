//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да
//  7 -> да
//  1 -> нет
Console.WriteLine("Введите число от 1 до 7");
int daynum = Convert.ToInt32(Console.ReadLine());

if(daynum == 6 || daynum == 7)
  {
  Console.WriteLine("да -> это выходной");
  }
  else if (daynum < 1 || daynum > 7) {
    Console.WriteLine("цифра меньше 1 и больше 7, введите цифру от 1 до 7");
  }
  else {Console.WriteLine("нет -> это не выходной");}