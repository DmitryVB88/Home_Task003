// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()??"");
int cube = 1;
for(int i = 0; i <= n; i++)
{
    cube = i * i * i;
    if (cube%2 == 0)
    {
        Console.Write($"{cube + " "}");
    }
}