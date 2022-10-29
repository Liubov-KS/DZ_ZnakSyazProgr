// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = (num%2);
if (result == 0)  // переменная , свойство или индексатор!
{
    System.Console.WriteLine($"да");            
}
else 
{
    System.Console.WriteLine($"нет");
}