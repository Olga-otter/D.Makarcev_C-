// String(char)
/*
string? stroka = Console.ReadLine();
Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);


// Array

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); // [-10, 10]

Console.WriteLine($"Результат: {string.Join(" , ", array)}");


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = i + 1;

Console.WriteLine($"Результат: {string.Join(" , ", array)}");



void f(int[] n)
{
    n[0] = n[0] + 5;
}

int[] n = {1, 2, 3, 4, 5};
f(n);
Console.WriteLine(string.Join(" ", n));


int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}


int a = 41, b = 63;
int result = f(a, b);
Console.WriteLine(result);


// 24

Console.Clear();
Console.Write("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {(1 + n) / 2 * n}");


// 26

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n = n / 10;
    count++;
}
Console.WriteLine(count);
*/


// 28

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 1;
for (int i = 2; i <= n; i++)
    count = count * i;

Console.WriteLine(count);

