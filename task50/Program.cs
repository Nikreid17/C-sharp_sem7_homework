// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

System.Console.Write("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
ReleaseArray(matrix);

void ReleaseArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == row && j == column)
        {
            System.Console.WriteLine(matrix[row, column]);
            return;
        }
        if (row >= size[0] || column >= size[1])
        {
            System.Console.WriteLine("Такого элемента нет.");
            return;
        }

    }
}
}