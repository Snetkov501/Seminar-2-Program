// Task 13
Console.Clear();

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0, x = 0;
if (n > 99)
{
    x = n;
    m = x % 10;
    while (x >= 1000)
    {
        x /= 10;
        m = x % 10;
    }
Console.WriteLine($"Дружище, третья цифра {m}");
}
else
{
    Console.WriteLine("Дружище, третьей цифры нет");
}