// Задача 31
/*
void IntputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}


void ReleaseArray(int[] array)
{
int summaPositive = 0, summaNegative = 0;
foreach (int element in array)
{
     if (element > 0)
     summaPositive += element;
  else
     summaNegative += element;
}
Console.WriteLine($"Сумма положительных элементов равна: {summaPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна: {summaNegative}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
IntputArray(array);


// Задача 32

void IntputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] *= (-1);
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
IntputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
IntputArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Задача 33

void IntputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}


string ReleaseArray(int[] array, int number)
{
foreach (int element in array)
{
  if (element == number)
     return "yes";
}
     return "no";
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
IntputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Введите число, которое Вы ищите внутри массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray (array, number));


// Задача 35

void IntputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101);
}


int ReleaseArray(int[] array)
{
int count = 0;
foreach (int element in array)
{
  if (element >= 10 && element <= 99)
     count++;
}
     return count;
}

Console.Clear();
int[] array = new int[123];
IntputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray (array));
*/

// Задача 37

void IntputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10);
}


void ReleaseArray(int[] array)
{
for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    Console.WriteLine($"{array[i] * array[array.Length - i - 1]}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
IntputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray (array);

