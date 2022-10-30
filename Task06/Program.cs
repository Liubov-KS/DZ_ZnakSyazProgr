// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5   //  78 -> третьей цифры нет    //  32679 -> 6
System.Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int result100 = num/100;
int result10 = num/10;

if(num > 99)   //  |||??result7 == 0 && result23 == 0)
{
    if(result100 == 0 || result10 ==0)
    {Console.WriteLine($"третья цифра числа -> {num[2]}");}
   
    
        else 
{
    System.Console.WriteLine("третьей цифры нет");
}
}   
   

   ||||||/////  if (N <100) cout << "нету";
else {
  for(; N>=1000; N/=10)
  ;
  ccut << N%10;
}