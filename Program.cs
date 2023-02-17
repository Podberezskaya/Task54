//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0,11);
    }
  }
}
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}
void SortingMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}
Console.Write ("Введите размер массива: ");
int [] size = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] matrix = new int[size [0], size[1]];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Конечный массив: ");
SortingMatrix(matrix);
PrintMatrix(matrix);
