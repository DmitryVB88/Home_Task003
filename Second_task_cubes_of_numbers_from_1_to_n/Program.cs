// Найти кубы чисел от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "");
for(int i = 1; i <= n; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"Число {i} в третьей степени = {cube}");
}