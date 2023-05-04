//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num /10000;
int num2 = num %10;
int num3 = num /10%10;
int num4 = num/100%10;
int num5 = num /1000%10;
int result = 0;
// Console.WriteLine($"Было введено число  {num}")
if (num>0)
    while (num > 0)
    {
        result *= 10;
        result += num % 10;
        num /= 10;
    }


int a = (num /= 10);
int x = 0;
if(num*2 ==  num+a)
{
    Console.WriteLine(result);
}
while (num + a >0)
{
   result = (num + a);
    
    Console.WriteLine(result);
}
if (num != a)
{
    Console.WriteLine(result);
    result++;
}
else if (num != a)
{
    Console.WriteLine(result);
}
else if (num1 == num2) 
{
    Console.WriteLine("yes");
}
else if(num1 == a)
{
    Console.WriteLine("yes");
}
else if (num1 != num2)
{
    Console.WriteLine("no");
}