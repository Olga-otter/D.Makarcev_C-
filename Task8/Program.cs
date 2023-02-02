// Задача 39
/*
void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReplaceElement(int[] array)
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    int temp = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = temp;
  }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный масссив: [{string.Join(", ", array)}]");
ReplaceElement(array);
Console.WriteLine($"Конечный масссив: [{string.Join(", ", array)}]");


// Задача 40

Console.Clear();
Console.Write("Введите 1-ую сторону треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ую сторону треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ю сторону треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
  Console.WriteLine("yes");
else
  Console.WriteLine("no");

  // Задача 42

  Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
while (n > 0)
{
  result = Convert.ToString(n % 2) + result;
  n = n / 2;
}
Console.WriteLine(result);

// Задача 44

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
  Console.Write($"{a0} ");
  x = a0 + a1;
  a0 = a1;
  a1 = x;
}
*/

// Задача 45
int[] a = {1, 2, 3, 4, 5};
int[] b = new int[a.Length];

for (int i = 0; i < a.Length; i++)
  b[i] = a[i];

b[0] = 100;
Console.WriteLine(string.Join(" ", a));
Console.WriteLine(string.Join(" ", b));
