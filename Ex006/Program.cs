// Дан целочисленный массив. 
// Найти среднее арифметическое каждого из столбцов.

float SredneeArifmStolbArray (int[,] array, int j)
{
    float sum=0;
    float sr_arif=0;
    for (int i=0; i<array.GetLength(0); i++)
        sum=sum+array[i,j];
    sr_arif=sum/array.GetLength(0);   
    return sr_arif;
}

void EnterArray (int[,] array, int min, int max)
{
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
            array[i,j]=new Random().Next(min,max);
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
Console.Write("Введите минимальный элемент массива: ");
int min=int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный элемент массива: ");
int max=int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m,n];

EnterArray(array, min, max); // заполняем массив элементами
Console.WriteLine("Введенный массив:");
PrintArray(array);

for (int j=0; j<array.GetLength(1); j++)
    Console.WriteLine("Среднее арифметическое столбца {0} = {1:F2}", 
    j+1, SredneeArifmStolbArray(array, j));      