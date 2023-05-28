        //  Домашняя работа .Кочеров Анатолий.

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



// System.Console.WriteLine("Введите числа");
// int i = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Введите числа");
// int i1 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите числа");
// int i2 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите числа");
// int i3 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите числа");
// int i4 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите числа");
// int i5 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите числа");
// int i6 = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите числа");
// int i7 = Convert.ToInt32(Console.ReadLine()); 
//     for(int num = 0; num < 1; num++)
//     {
//         System.Console.WriteLine($"Массив : [{i},{i1},{i2},{i3},{i4},{i5},{i6},{i7}]");
//     }




// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num1 = Convert.ToInt32(Console.ReadLine());
int oppo = 0;
int result = 0;
int n = 0;
while (oppo < 1)
{
    while (n < 1)


    {
         result = (num*num)*num1;
        System.Console.WriteLine($"Результат возведения в степень : {   result  }");
        n++;
    }
   
    
    oppo++;
   
}
return result;
