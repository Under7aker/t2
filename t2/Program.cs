// See https://aka.ms/new-console-template for more information




using System.Runtime.InteropServices;

Console.Write("Introduceti numărul de rânduri al matricei: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Introduceti numărul de coloane al matricei: ");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, columns];

Console.WriteLine("Introduceti elementele matricei:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Elementul [{i}, {j}]: ");
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

// Rotește matricea cu 90 de grade în loc
RotateMatrixClockwise(matrix);

// Afișează matricea rotită
Console.WriteLine("Matricea rotită cu 90 de grade:");
PrintMatrix(matrix);
static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
static void RotateMatrixClockwise(int[,] matrix)
{
    int n = matrix.GetLength(0);

    for (int layer = 0; layer < n / 2; layer++)
    {
        int first = layer;
        int last = n - 1 - layer;

        for (int i = first; i < last; i++)
        {
            int offset = i - first;

            int top = matrix[first, i];

            // Mutăm elementele din stânga în sus
            matrix[first, i] = matrix[last - offset, first];

            // Mutăm elementele de jos în stânga
            matrix[last - offset, first] = matrix[last, last - offset];

            // Mutăm elementele din dreapta în jos
            matrix[last, last - offset] = matrix[i, last];

            // Mutăm elementele de sus în dreapta
            matrix[i, last] = top;
        }
    }
}




