int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0 && n > 0)
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return (Akkerman(n - 1, Akkerman(n, m - 1)));
    }
}

try
{
    Console.WriteLine("Введите первое число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine();
    Console.WriteLine(Akkerman(n, m));
}

catch
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
}




