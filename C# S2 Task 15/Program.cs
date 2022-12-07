// Task 15
Console.Clear();

Console.WriteLine("Введите число от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 8 & n > 5)
{
    Console.WriteLine("Дружище, возрадуйся у тебя ВЫХОДНОЙ!");
}
else if (n >0 & n < 6)
{
    Console.WriteLine("Дружище, надо поработать");
}
else
{
Console.WriteLine("Дружище, некоректные данные. Сказано же ведь от 1 до 7");
}
