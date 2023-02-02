Console.Clear();

Console.WriteLine("Введите координаты точки A, ось X:");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Далее ось Y");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Далее ось Z");
int c1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B, ось X: ");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Далее ось Y");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Далее ось Z");
int c2 = int.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2,2) + Math.Pow(c1 - c2,2));
Console.WriteLine(x);