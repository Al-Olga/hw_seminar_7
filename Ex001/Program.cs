// Показать двумерный массив размером m×n заполненный вещественными числами
void EnterArray (double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=new Random().NextDouble()*10;
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write("{0:F2} ", array[i,j]);
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int m=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int n=int.Parse(Console.ReadLine() ?? "0");

double[,] array = new double[m,n];

EnterArray(array); // заполняем массив элементами

PrintArray(array);