// 44. Вывести первые N чисел Фибоначчи (без рекурсии).

double Fibonacci(int n)
{
    double a = 1;
    double b = 1;
    double c = 0;
    if (n == 0 || n == 1) return 1;
    else
    {
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
    }
    return c;
}
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Порядковый номер - {i} = {Fibonacci(i)}");
}