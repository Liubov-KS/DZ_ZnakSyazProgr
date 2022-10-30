// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5   //  78 -> третьей цифры нет    //  32679 -> 6
System.Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
if (threeDigitNumber > 99)
{System.Console.WriteLine("третья цифра числа, -> "+stringNumber[2]);}
else 
{System.Console.WriteLine("третьей цифры нет");}