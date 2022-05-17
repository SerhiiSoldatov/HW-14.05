// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
int m = 5;
int n = 5;
double[,] mass = new double[m, n];
Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = random.NextDouble() * 10;
        System.Console.Write("{0,6:F1}", mass[i, j]);
    }
    System.Console.WriteLine();
}
