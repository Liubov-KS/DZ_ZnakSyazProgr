//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("Введите три числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num3;

if(max < num1)
{
    if(max < num2)   
{   
        max = num2;
        Console.WriteLine(max);}
        else 
    {   max = num1;
        Console.WriteLine(max);}
}
else if (max < num2)
        {   max = num2; 
            Console.WriteLine(max);    }
        else {
            max = num3; 
            Console.WriteLine(max);     }
        
    
    


// int max = Max(array[0],array[1],array[2]); int max = Max( num1,  num2,  num3);
//Console.WriteLine(max);

// if
// {
// int max = arg1;
// if(arg2 > max)  max = arg2;
// if(arg3 > max)  max = arg3;
// return max;
// }
// int[] array = {};
// int max = Max(array[0],array[1],array[2]);
// Console.WriteLine(max);