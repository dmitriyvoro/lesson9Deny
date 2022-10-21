 int SummaNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + SummaNumbers(m, n - 1); 
    else return n + SummaNumbers(m, n + 1);            
}

Console.Write("введите первое число : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма положительных чисел = {SummaNumbers(m, n)}");