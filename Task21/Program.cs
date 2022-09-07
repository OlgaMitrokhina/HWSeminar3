// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите первую координату точки А");
int Ax = Convert.ToInt32(Console.ReadLine()); // x1
Console.WriteLine("Введите вторую координату точки А");
int Ay = Convert.ToInt32(Console.ReadLine()); //y1
Console.WriteLine("Введите третью координату точки A");
int Az = Convert.ToInt32(Console.ReadLine()); //z1

Console.WriteLine("Введите первую координату точки B");
int Bx = Convert.ToInt32(Console.ReadLine()); // x2
Console.WriteLine("Введите вторую координату точки B");
int By = Convert.ToInt32(Console.ReadLine()); // y2
Console.WriteLine("Введите третью координату точки B");
int Bz = Convert.ToInt32(Console.ReadLine()); //z2


double rez = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
Console.WriteLine($"Расстояние между точками A и B равно {rez}");
