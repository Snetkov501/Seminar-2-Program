// Task 10
Console.Clear();

Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n/10;
int n2 = n1%10;

Console.WriteLine($"Дружище, вторая цифра {n2}");