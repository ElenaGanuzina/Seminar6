// 40. На вход - три числа. Проверить, существует ли треугольник с такими сторонами.

void ExistTriangle( int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a) Console.WriteLine("Такой треугольник существует");
    else  Console.WriteLine("Такого треугольника не существует");
}

ExistTriangle(10, 6, 15);
ExistTriangle(6, 7, 38);