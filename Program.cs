

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
int size = 0;
int n = 100;
int result = 1;

while (index < n)
{
    
    index++;
    Console.WriteLine(index*index*index);
}
if (num > size)
{
    num = result * 3;
    size++;
    Console.WriteLine(size);
    
}


 else if (num >= n)
{
    Console.WriteLine("Таблица построенна");
}