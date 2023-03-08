void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Decrease(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temporary = matr[i, j];
            matr[i, j] = matr[i, maxPosition];
            matr[i, maxPosition] = temporary;
        }
    }
}

int rows,
    columns;
do
{
    Console.WriteLine("Введите количество строк и столбцов матрицы (больше нуля)");
    rows = Convert.ToInt32(Console.ReadLine());
    columns = Convert.ToInt32(Console.ReadLine());
} while ((rows <= 0) || (columns <= 0));

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Упорядоченный массив:");
Decrease(matrix);
PrintArray(matrix);
