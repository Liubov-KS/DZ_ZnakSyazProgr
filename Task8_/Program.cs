/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет    
12821 ->да    
23432 -> да
*/
 Console.Write("Введите 5-ти значное число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");

++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
// Palindrome bool

class Program
{
  static void Main(string[] args)
{
  int numPalindrome = SetNumber("Palindrome");

  bool isPalindrome = isPalindromeInt(numPalindrome);

  string str = isPalindrome ? "является палиндромом" : "не является палндромом";

  if (isPalindrome)
  {
    string str = "является палиндромом";
  }
  else
  {
    string str = "не является палиндромом";
  }
  System.Console.WriteLine($"число {numPalindrome} {str}");
}
}