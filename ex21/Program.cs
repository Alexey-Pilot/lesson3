Console.Clear();
Console.Write("Введите координаты Х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double len = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1-z2, 2)),2);
Console.WriteLine($"Расстояние между точками равняется {len}");