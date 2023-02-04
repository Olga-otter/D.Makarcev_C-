// ДЗ 41
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Результат: {count}");


// ДЗ 43

Console.Clear();
Console.Write("Введите значения k(1): ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значения b(1): ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значения k(2): ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значения b(2): ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Результат: ({x}, {y})");
*/

// ДЗ доп Площадь треугольника

Console.Clear();
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double x3 = Convert.ToDouble(Console.ReadLine());
double y3 = Convert.ToDouble(Console.ReadLine());
double A = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double B = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
double C = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
double p = (A + B + C) / 2;
double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
Console.WriteLine(S);
