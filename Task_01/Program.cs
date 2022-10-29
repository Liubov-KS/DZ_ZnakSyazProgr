// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

//      num1  a = 5;  num2 b = 7 -> max = 7
//      a = 2 b = 10 -> max = 10
//      a = -9 b = -3 -> max = -3
// num1  a = 5;  num2 b = 7 -> max = 7

System.Console.WriteLine("Enter two numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > num1)  
{
    System.Console.WriteLine($"максимальное число {num2}, минимальное число {num1} ");
}
if (num1 > num2)  
{  
    System.Console.WriteLine($"максимальное число {num1}, минимальное число {num2} ");;
}
