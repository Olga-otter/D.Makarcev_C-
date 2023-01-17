// ДЗ 2
/*
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    Console.WriteLine(n);
else if (m > n)
    Console.WriteLine(m);
else
    Console.WriteLine("Числа равны");
    */

    // ДЗ 4
/*
    Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine()), max = a;
if (a >= b && a >= c)
    Console.WriteLine(a);
else if (b >= a && b >= c)
    Console.WriteLine(b);
else
    Console.WriteLine(c);
    */

   // ДЗ 6
/*
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 1)
    Console.WriteLine("Нечетное");
else
    Console.WriteLine("Четное"); 
*/

// ДЗ 8
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 2;
while (count <= n)
{
Console.Write($"{count} ");
count = count + 2;
}
     

     Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count;
if (n < 0)
{
    count = -2;
    while (count >= n)
    {
        Console.Write($"{count} ");
        count = count - 2;
    }
}
else
{
    count = 2;
    while (count <= n)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}  
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i += 2)
Console.Write($"{i} ");