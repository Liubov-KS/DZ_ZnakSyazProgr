// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. два Вар: Стринг и Математика.
// 456 -> 5
//782 -> 8
//918 -> 1

// вар стринг ++++ индекс

    System.Console.WriteLine("Введите трехзначное число");
    int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

    string stringNumber = Convert.ToString(threeDigitNumber);
    System.Console.WriteLine("вторая цифра числа, -> "+stringNumber[1]);

//  ++++++++ вариант через % и /  ++++++++++
System.Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine()); 

if (threeDigitNumber < 1000 &&  threeDigitNumber > 99)
{   
    int result = threeDigitNumber%100 / 10;
    System.Console.WriteLine($"показываем вторую цифру числа: {result}");
}
 else
 {
   System.Console.WriteLine($"Число не трехзначное.ВВедите трехзначное число"); 
 }   
   