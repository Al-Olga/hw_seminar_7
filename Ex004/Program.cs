// В двумерном массиве показать позиции числа, 
// заданного пользователем или указать, что такого элемента нет

// обнуляем массив для временного хранения индексов найденного элемента
void ObnulArrayFind(int[] array)
{
    for (int i=0; i<array.Length; i++)
        array[i]=0;
}

int[] FindElement(int[,] array, int element, int strok, int stolb, int flag)
{
    int [] array_find = new int[3];
    ObnulArrayFind(array_find);
    if (flag==0) stolb=0; // если это первый "проход", то принудительно на нулевой индекс столбца
    for (int i=strok; i<array.GetLength(0); i++) // поиск начинаем с индекса строки найденного элемента
    {   // поиск начинаем со следующего индекса столбца найденного элемента
        for (int j=stolb; j<array.GetLength(1); j++) 
            if (array[i,j]==element)
            {
                array_find[0]=i; // сохраняем позицию в строке
                array_find[1]=j; // сохраняем позицию в столбце
                array_find[2]=1; // "флаг", что элемент найден
                return array_find;
            }
        stolb=0;
    }
    array_find[0]=array.GetLength(0);
    array_find[1]=array.GetLength(1);
    return array_find;
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

// создаем массив для временного хранения индексов найденного элемента
int[] ArrayFind = new int[3];
Console.Write("Введите число для его поиска в массиве: ");
int number=int.Parse(Console.ReadLine() ?? "0");
int count=0;
while (ArrayFind[0]<array.GetLength(0) & ArrayFind[1]<array.GetLength(1))
{
    // в функцию передаем: массив, число для поиска, 
    // индексы с которых начинать поиск (для индекса столбца 
    // за начало принят индекс следующего за найденным)
    ArrayFind=FindElement(array, number, ArrayFind[0], ArrayFind[1]+1, count);
    if (ArrayFind[2]==1)
    {
        Console.WriteLine($"Число {number} найдено в строке {ArrayFind[0]+1}, столбце {ArrayFind[1]+1}");
        count++;
    }
}
if (count==0)
        Console.WriteLine($"Число {number} не найдено");
