void Nat(int n)
{
    if (n <= 0)
    {
        Console.WriteLine("Введен ноль или отрицательное число");
    }
    else if (n > 1)
    {
        Console.Write(n + ", ");
        Nat(n - 1);
    }
    else
    {
        Console.Write(n);
    }

}

try
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());

    Nat(n);
}
catch
{
    Console.WriteLine("Введено неверное значение");
}