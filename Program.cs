// Необходимо возвести число a в степень b

int f(int a, int b)
{
  if (b == 0)
    return 1;
  return f(a, b - 1) * a;
}


Console.Clear();
Console.WriteLine(f(3, 5));
