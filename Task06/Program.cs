// ДЗ 19
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = (n / 1000) % 10;
int n4 = (n % 100) / 10;
int n5 = n % 10;
if (n1 == n5 && n2 == n4)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");
    

    // ДЗ 21

    Console.Clear();
Console.Write("Введите координату X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Результат: {Math.Round(S, 2)}");


// ДЗ 23

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");
    */

    // Доп

    int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
 
int maxSumma = 0;
for (int i = 1; i < array.Length - 1; i++)
{
    int sum = array[i - 1] + array[i] + array[i + 1];
    if (sum > maxSumma)
        maxSumma = sum;
}
if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
    maxSumma = array[0] + array[1] + array[array.Length - 1];
 
if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
    maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];
 
Console.WriteLine(maxSumma);