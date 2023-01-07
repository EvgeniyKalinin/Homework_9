int Sum(int n, int m)
{
    int res = n;
    if (n == m)
    {
        return res;
    }
    else
    {
        n++;
        res = n + Sum(n, m);
        return res;
    }
}

try
{
    Console.WriteLine("Введите меньшее число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите большее число");
    int m = Convert.ToInt32(Console.ReadLine());

    if (n > m)
    {
        Console.WriteLine("Некорректный ввод, попробуйте снова.");
    }
    else
    {
        Console.Write(Sum(n - 1, m));
    }
}

catch
{
    Console.WriteLine("Некорректный ввод, попробуйте снова.");
}

