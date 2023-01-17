/*
Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m * m == n)
    Console.WriteLine("yes");
else
Console.WriteLine("no");    


Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
 Console.Write("Вы ошиблись!\nВведите день недели: ");
 n = Convert.ToInt32(Console.ReadLine()); 
}
if (n == 1)
Console.WriteLine("Понедельник");
else if (n == 2)
Console.WriteLine("Вторник");
else if (n == 3)
    Console.WriteLine("Среда");
else if (n == 4)
    Console.WriteLine("Четверг");
else if (n == 5)
    Console.WriteLine("Пятница");
else if (n == 6)
    Console.WriteLine("Суббота");
else
    Console.WriteLine("Воскресенье");


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n * (-1);
while (m <= n)
{
Console.Write($"{m} ");
m = m + 1; 
}
*/

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);