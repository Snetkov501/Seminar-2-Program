// Additional task
Console.Clear();
Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m1 = n; 
int m2 = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > m1)
    {
    m2 = m1;
    m1 = n;
    }
    else if (n > m2)
        m2 = n;
}
Console.WriteLine($"Дружище, второй максимум {m2}");