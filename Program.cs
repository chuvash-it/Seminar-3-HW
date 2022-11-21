// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Координаты точки А");
Console.Write("х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки B");
Console.Write("х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(x2 - x1, 2) + Math.Pow(x2 - x1, 2));
  return result;
}
double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между точками А и В в 3D пространстве: " + distance);
