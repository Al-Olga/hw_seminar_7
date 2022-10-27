// Написать программу, которая обменивает 
// элементы первой строки и последней строки

// Вариант 1. когды мы в программе указываем номера строк для замены
void ZamenaElem (int[,] array)
{
    int tmp;
    for (int j=0; j<array.GetLength(1); j++)
    {
        tmp=array[0,j];
        array[0,j]=array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j]=tmp;
    }
}

// Вариант 2
// когда номера строк для замены введятся пользователем
// (общий случай)
void ZamenaElemUzer (int[,] array, int str1, int str2)
{
    int tmp;
    for (int j=0; j<array.GetLength(1); j++)
    {
        tmp=array[str1,j];
        array[str1,j]=array[str2,j];
        array[str2,j]=tmp;
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

ZamenaElem (array);

Console.WriteLine("Массив после замены элементов первой и последней строки:");
PrintArray(array);

// Более общий случай, когда пользователь 
// вводит номера строк, элементы которых нужно поменять.
// Считаем, что пользователь вводит обычную нумерацию, начиная с 1, а не с 0
Console.Write($"Введите номер первой строки для обмена (в диапазоне от 1 до {array.GetLength(0)}): ");
int str1=int.Parse(Console.ReadLine() ?? "0")-1;
if ((str1<array.GetLength(0)) & str1>=0)
{
    Console.Write($"Введите номер второй строки для обмена (в диапазоне от 1 до {array.GetLength(0)}): ");
    int str2=int.Parse(Console.ReadLine() ?? "0")-1;
    if (((str2<array.GetLength(0)) & str2>=0) & (str1!=str2))
    {
        ZamenaElemUzer (array, str1, str2);
        Console.WriteLine($"Массив после замены элементов строки {str1+1} и {str2+1}:");
        PrintArray(array);
    }
    else Console.WriteLine("Номера строк заданы не корректно");
}
else Console.WriteLine("Номера строк заданы не корректно");