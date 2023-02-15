// Задача 66
/*
public class partial
{
   public static void Main()
   {
       Console.WriteLine("Введите число M:");
           int m = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите число N:");
           int n = Convert.ToInt32(Console.ReadLine());
       
       int start = m;
       int finish = n;
       if (m > n)    {start = n; finish = m;}

       int Summa(int small, int big)
           {
               if(small == big) return small;
               return small + Summa(small + 1, big);
           }
 
       int SummaMN = Summa(start, finish);  
       Console.WriteLine($"Сумма натуральных элементов в промежутке = {SummaMN}");
   }
}

*/
// Задача 68

Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            A(n, m);

    static int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, m);
        return A(n - 1, A(n, m - 1));
    }
    static void Main(string[] args)
    {
        Console.WriteLine(A(2, 5));
        Console.WriteLine(A(1, 2));
    }


    