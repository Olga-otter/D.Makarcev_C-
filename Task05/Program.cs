// ДЗ 10

/*
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = (n / 10) % 10;
Console.WriteLine(n2);

// ДЗ 13

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("Третьей цифры нет");
else
{
    while (n >= 999)
    {
        n = n / 10;
    }
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}

// ДЗ 15

Console.Clear();
Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Нет");
else if (n == 2)
    Console.WriteLine("Нет");
else if (n == 3)
    Console.WriteLine("Нет");
else if (n == 4)
    Console.WriteLine("Нет");
else if (n == 5)
    Console.WriteLine("Нет");
else if (n == 6)
    Console.WriteLine("Да - выходной");
else
    Console.WriteLine("Да - выходной");
    */
   // Доп

    Console.Clear();
int n = Convert.ToInt32(Console.ReadLine()), max1 = n, max2 = 0;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    else if (n > max2)
        max2 = n;
}
Console.WriteLine(max2);
