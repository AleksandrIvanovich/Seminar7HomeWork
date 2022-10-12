/*
Задача 50. Напишите программу, которая на вход принимает число и 
возвращает позицию (i, j) этого элемента или же указание, что такого элемента нет.
*/
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int [,] InitMatrix(int m, int n)
{
  int[,] matrix = new int[m, n];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         matrix[i,j] = rnd.Next(1, 10);
     }
  }
  return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindColumnNumber(int value, int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {    
            if (matrix[i,j] == value)
             {
              return i+1;
             }    
        }
    } 
   return - 1; 
}

int FindLineNumber(int value, int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == value)
            {
             return j+1;
            }
        }      
    }  
  return -1;
}

int m = GetNumber("Введите число (количество строк)");
int n = GetNumber("Введите число (количество столбцов)");
int value = GetNumber("Введите искомое число ");
int[,] matrix = InitMatrix(m, n);

int x = FindLineNumber(value, matrix);
int y = FindColumnNumber(value, matrix);

Console.WriteLine("Матрица:");
PrintMatrix(matrix);
if (x<0)
{
    Console.WriteLine("Такого числа нет!");
}
else
{
Console.WriteLine($"Число {value} находится в {y} строке {x} столбца.");
}