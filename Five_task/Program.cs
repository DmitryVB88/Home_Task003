// Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите степень, в которую нужно возвести число: ");
int b = int.Parse(Console.ReadLine() ?? "");
int count = 1;
int power = 1;
while (count <= b)
{
    power = power * a;
    count++;
    
}
Console.WriteLine(power);

// Второй вариант, через цикл for:

for(int i = 1; i <= b; i++ )
{
    power = power * a; 
    Console.WriteLine($"{power}");
}