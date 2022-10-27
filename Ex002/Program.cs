// Задать двумерный массив следующим правилом: A[m,n] = m+n
void EnterArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=i+j;
}

void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write($"{array[i,j]} ");
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n=int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m,n];

EnterArray(array); // заполняем массив элементами

PrintArray(array);