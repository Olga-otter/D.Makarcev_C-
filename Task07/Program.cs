// ДЗ 29
/*
Console.Clear();
int[] array = array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = i + 1;

Console.WriteLine($"Результат: {string.Join(", ", array)}");

// ДЗ 27

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 0;
while (n > 0)
{
    result = result + n % 10;
    n = n / 10;
}
Console.WriteLine(result);
*/

// ДЗ 25

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i<=m; i++)
result = result * n;
Console.WriteLine(result);