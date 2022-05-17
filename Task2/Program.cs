// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

int m = 5;
int n = 5;
int[,] mass = new int[m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
        System.Console.Write(mass[i, j] + " ");
    }
    System.Console.WriteLine();
}
Console.WriteLine("Введите индекс строки: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int b = int.Parse(Console.ReadLine());
if (a > mass.GetLength(0) && b > mass.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    int fined = mass[a, b];
    System.Console.WriteLine($"Искомый элемент массива имеет значение: {fined}");
}