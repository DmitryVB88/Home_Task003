// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();

int[] array = new int[8];

for(int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 2);
}

int count = 1;

foreach(int n in array)
{
     Console.WriteLine($"{count} элемент массива равен {n}");
    count++;
}

