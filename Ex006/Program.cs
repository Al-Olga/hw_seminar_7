// Дан целочисленный массив. 
// Найти среднее арифметическое каждого из столбцов.

void SumStolbArray (int[,] array)
{
    float sum;
    for (int j=0; j<array.GetLength(1); j++)
    {
        sum=0;
        for (int i=0; i<array.GetLength(0); i++)
            sum=sum+array[i,j];
        Console.WriteLine($"Сумма элементов столбца({j+1})= {sum}");
        Console.WriteLine("Среднее арифметическое = {0:F2}", sum/array.GetLength(1));
    }
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
SumStolbArray(array);