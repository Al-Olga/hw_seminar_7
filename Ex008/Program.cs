// В прямоугольной матрице найти строку с наименьшей суммой элементов.

int SumElem (int[,] array, int stroka)
{
    int sum_i=0;
    for (int j=0; j<array.GetLength(1); j++)
        sum_i=sum_i+array[stroka,j];
    return sum_i;
}

int StrokaMin (int[,] array)
{
    int min_str=SumElem(array, 0);
    int tmp;
    int find_str=0;
    for (int i=1; i<array.GetLength(0); i++)
    {
        tmp=SumElem(array, i);
        if (min_str>tmp) 
        {
            min_str=tmp;
            find_str=i;
        }
    }
    return find_str; 
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

Console.WriteLine($"Номер строки с минимальной суммой = {StrokaMin (array)+1}");
