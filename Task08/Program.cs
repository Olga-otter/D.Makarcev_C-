// ДЗ 34
/*
void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}
int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
      if (element % 2 == 0)
        count++;
          }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {CountEvenInArray(array)}");


// ДЗ 36

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101);
}

int SummaOddInArray(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2)
      summa = summa + array[i];
    return summa;
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {SummaOddInArray(array)}");

// ДЗ 38

void InputArray(double[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
}

string DiffMaxAndMin(double[] array)
{
  double minArray = array[0], maxArray = array[0];
  foreach (double element in array)
  {
    if (element > maxArray)
      maxArray = element;
    if (element < minArray)
      minArray = element;
  }
  return $"{maxArray} - {minArray} = {maxArray - minArray}";
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {DiffMaxAndMin(array)}");

// Доп Суперсдвиг

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
int[] arrayResult = new int[n];
for (int i = 0; i < arrayFirst.Length; i++)
{
  arrayFirst[i] = new Random().Next(1, 11); // [1, 10]
}
Console.WriteLine($"[{string.Join(", ", arrayFirst)}]");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
  for (int i = 0; i < k; i++)
      arrayResult[i] = arrayFirst[n - k + i];
  for (int i = 0; i < n - k; i++)
      arrayResult[k + i] = arrayFirst[i];
  Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
}
else
{
  k = (-1) * k;
  for (int i = 0; i < k; i++)
      arrayResult[n - k + i] = arrayFirst[i];
  for (int i = 0; i < n - k; i++)
      arrayResult[i] = arrayFirst[k + i];
  Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
}


// Доп Гипотиза Гольдбаха

int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
  countDel = 0;
  for (j = 2; j <= i / 2; j++)
  {
    if (i % j == 0)
        countDel++;
  }
  if (countDel == 0)
  {
    m = n - i; // 992 - 73 = 919
    for (k = 2; k <= (m + 1) / 2; k++)
    {
      if (m % k == 0)
        countDel++;
    }
    if (countDel == 0)
    {
      Console.WriteLine($"{i} {m}");
      return;
    }
  }
}
*/

// ДЗ - оценка Васи, статистика

int n = Convert.ToInt32(Console.ReadLine());
int[] array = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int countEven = 0, countOdd = 0;
foreach (int element in array)
{
  if (element % 2 == 1)
  {
    Console.Write($"{element} ");
    countEven++;
  }
}
Console.WriteLine();
foreach (int element in array)
{
  if (element % 2 == 0)
  {
    Console.Write($"{element} ");
    countOdd++;
  }
}
Console.WriteLine();
if (countOdd >= countEven)
  Console.WriteLine("YES");
else
  Console.WriteLine("NO");