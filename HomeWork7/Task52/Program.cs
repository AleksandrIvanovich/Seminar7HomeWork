/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
 в каждом столбце.
*/
//Random rnd = new Random();
//int[,] matrix = new int[rnd.Next(1, 10), rnd.Next(1, 10)];
int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = int.Parse(Console.ReadLine());
  return number;
}
Random rnd = new Random();
double [,] InitMatrix(int m, int n)
{
  double[,] matrix = new double[m, n];
  
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        matrix[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
     }
  }
  return matrix;
}
int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
Console.WriteLine();
double[,] matrix = InitMatrix(m, n);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("-------------------------");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{ sum / matrix.GetLength(0)}|");
}

Console.WriteLine();