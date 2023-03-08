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

int MinLine(int[,] matr)
{
    int minSum = 0;
    int requiredLine = 0;

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            minSum += matr[i, j];
        }
    }

    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumLine += matr[i, j];
        }
        if (sumLine < minSum)
        {
            minSum = sumLine;
            requiredLine = i;
        }
    }
    return requiredLine;
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

Console.WriteLine("Номер строки с наименьшей суммой элементов (отсчет с нуля) = " + MinLine(matrix));
