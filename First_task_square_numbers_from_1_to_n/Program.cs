// Показать таблицу квадратов чисел от 1 до N
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "");
for(int i = 1; i <= n; i++)
{
    int mult = i * i;
    Console.Write($"{mult + " "}");
}
