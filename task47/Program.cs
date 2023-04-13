// Задайте двумерный массив размером M x N,
// заполненный случайными вещественными числами.

Console.Clear();

System.Console.WriteLine("Количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(1, 10));
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

double[,] matrix = new double[m, n];
InputMatrix(matrix);
