
Console.WriteLine("Введите первую сторону ");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую сторону ");
double y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третью сторону ");
double z = double.Parse(Console.ReadLine());
double P = x + y + z;
Console.WriteLine($"Периметр: {P}");
double p = P / 2;
double S = Math.Sqrt(p * (p - x) * (p - y) * (p - x));
Console.WriteLine($"Площадь: {S:F2}");
