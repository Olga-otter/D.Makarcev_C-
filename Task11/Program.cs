// Задача 53
/*
void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}

void ScreenMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}


void ReleaseMatrix(int[,] matrix)
{
  int temp = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    temp = matrix[0, j];
    matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
    matrix[matrix.GetLength(0) - 1, j] = temp;
  }
}


Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);


// Задача 55

void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}
void ScreenMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix)
{
  int temp = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < i; j++)
    {
      temp = matrix[i, j];
      matrix[i, j] = matrix[j, i];
      matrix[j, i] = temp;
  }
}
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
while (size[0] != size[1])
{
    Console.Write("Вы ошиблись!\nВедите размеры массива: ");
    size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);
ScreenMatrix(matrix);

// Задача 57

bool checkElement(int[] array, int number)
{
    foreach (int element in array)
    {
        if (number == element)
            return false;
    }
    return true;
}

int FillMatrix(int[,] matrix, int[] HelpArray)
{
  int k = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int number = new Random().Next(1, 11);
      matrix[i, j] = number;
      if (checkElement(HelpArray, number) == true)
      {
        HelpArray[k] = number;
        k++;
      }
    }
  }
  return k;
}

void ScreenMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix, int[] array, int count)
{
    for (int k = 0; k < count; k++)
    {
        int countUnieq = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i, j])
                    countUnieq++;
            }
        }
        Console.WriteLine($"Число {array[k]} встречается {countUnieq} раз");
    }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[] HelpArray = new int[size[0] * size[1]];
int k = FillMatrix(matrix, HelpArray);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix, HelpArray, k);
*/


// Задача 59

void FillMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
    }
  }
}
void ScreenMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

void ReleaseMatrix(int[,] matrix)
{
  int min = matrix[0, 0];
  int minIndexI = 0;
  int minIndexJ = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     if (matrix[i, j] < min)
     {
      min = matrix[i, j];
      minIndexI = i;
      minIndexJ = j;
     }
    }
  } 
  Console.WriteLine($"min = {min}; [{minIndexI}, {minIndexJ}]");

  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    if (i != minIndexI)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != minIndexJ)
                Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
  }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[ , ] matrix = new int[size[0], size[1]];
FillMatrix(matrix);
ScreenMatrix(matrix);
Console.WriteLine();
ReleaseMatrix(matrix);