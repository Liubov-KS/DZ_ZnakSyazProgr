﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
//782 -> 8
//918 -> 1

System.Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threeDigitNumber);
System.Console.WriteLine("вторая цифра числа, -> "+stringNumber[1]);