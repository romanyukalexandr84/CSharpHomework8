void FillArray(int[,,] matr)
{
    int[] uniqueArray = new int [matr.GetLength(0)*matr.GetLength(1)*matr.GetLength(2)];
    for (int i = 0; i < uniqueArray.Length; i++)
    {
        int temp = new Random().Next(10,100);
        while (uniqueArray.Contains(temp))
        {
            temp = new Random().Next(10,100);
        }
        uniqueArray[i] = temp;
    }

    int l = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = uniqueArray[l];
                l++;
            }
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}

int rows,
    columns,
    depth;
do
{
    Console.WriteLine("Введите количество строк, столбцов и глубину матрицы (больше нуля)");
    rows = Convert.ToInt32(Console.ReadLine());
    columns = Convert.ToInt32(Console.ReadLine());
    depth = Convert.ToInt32(Console.ReadLine());
} while ((rows <= 0) || (columns <= 0) || (depth <= 0));

int[,,] matrix = new int[rows, columns, depth];
FillArray(matrix);
PrintArray(matrix);
