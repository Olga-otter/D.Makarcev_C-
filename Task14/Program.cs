// Необходимо возвести число a в степень b
/*
int f(int a, int b)
{
  if (b == 0)
    return 1;
    Console.WriteLine(a);
  return f(a, b - 1) * a;
}


Console.Clear();
Console.WriteLine(f(3, 5));

// Задача 63

string f(int n)
{
  if (n == 1)
    return "1";
  return f(n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));


// Задача 65

string f(int m, int n)
{
  if (n == m)
    return $"{m}";
  return f(m, n - 1) + $", {n}";
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));


// Задача 67

int f(int n)
{
  if (n < 10)
    return n;
  return f(n / 10) + n % 10;
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/
// Фибоначчи

int f(int n)
{
  if (n == 0) 
    return 0;

  if (n == 1) 
    return 1;
  return f(n - 1) + f(n - 2);
}


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));



