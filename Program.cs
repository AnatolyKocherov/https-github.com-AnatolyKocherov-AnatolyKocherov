// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Домашняя работа ;
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите координаты двух точек A(x,y,z);B(x1,y1,z1)");
int x = Coordinate("x", "A");
int y = Coordinate("y", "A");
int z = Coordinate("z", "A");
int x1 = Coordinate("x", "B");
int y1 = Coordinate("y", "B");
int z1 = Coordinate("z", "B");

int Coordinate( string coorName ,string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x, double x1, 
                double y, double y1, 
                double z, double z1){
  return Math.Sqrt(Math.Pow((x-x1), 2) + 
                   Math.Pow((y-y1), 2) + 
                   Math.Pow((z-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x, y1, y, z1, z), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
