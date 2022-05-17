// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int m = 5;
int n = 5;
int[,] matrix = new int[m, n];
Random rand = new Random();
int[] summ = new int[n];
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10); //рандомные значения для елементов матрицы
                    
        }
    }
Console.WriteLine();
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {         
            Console.Write(matrix[i, j]); //вывод матрицы
            summ[i] += matrix[j, i];      //подсчет суммы колонки
        } 
        Console.WriteLine();
    }
Console.WriteLine();
foreach (double item in summ)
{
    System.Console.WriteLine($"среднее арифметическое = {item/n}; ");
}
  

