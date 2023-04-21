// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    
    return myArray;
}

int CountEvens(int[] myArray)
{
    int count = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0)
        {
            count++;
        }   
    }
    System.Console.WriteLine($"Колличество четных чисел в массиве равно: {count}");
    return count;
}
void printArray (int [] myArray) 
{
    System.Console.WriteLine("Представлен массив: " );
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write($"{myArray[i]} ");
    }
    System.Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, 100, 999);
printArray(myArray);
int evensCount = CountEvens(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

int SumEvenPositions(int[] myArray)
{
    
    int result = myArray.Where(i=>i%2==0).Sum();

    System.Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях в массиве равна: {result}");
    return result;
}
void printArray (int [] myArray) 
{
    System.Console.WriteLine("Представлен массив: " );
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write($"{myArray[i]} ");
    }
    System.Console.WriteLine();
}
int[] myArray = CreateRandomArray(10, 1, 99);
printArray(myArray);
int evensCount = SumEvenPositions(myArray);

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

int DifBetwMaxMinPositions(int[] myArray)
{
    
    int result = ((myArray.Max())-(myArray.Min()));
    
    System.Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {result}");
    return result;
}
void printArray (int [] myArray) 
{
    System.Console.WriteLine("Представлен массив: " );
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write($"{myArray[i]} ");
    }
    System.Console.WriteLine();
}
int[] myArray = CreateRandomArray(10, 1, 99);
printArray(myArray);
int evensCount = DifBetwMaxMinPositions(myArray);