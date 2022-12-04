// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2.
void Task34()
{
    Console.WriteLine("Программа задаёт массив, заполненный случайными положительными трёхзначными числами, и показывает количество чётных чисел в массиве.");
    int size = 8;
    int[] numbers = new int[size];
    int result = 0; 
    FillArrayIntegers(numbers, 100, 999);
    PrintArrayIntegers(numbers);

    for (int i = 0; i < size; i++) if (numbers[i] % 2 == 0) result++;
    Console.WriteLine($"Количество чётных чисел в массиве равно {result}.");
    Console.WriteLine();
    Console.WriteLine();
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0.
void Task36()
{
    Console.WriteLine("Программа задаёт одномерный массив, заполненный случайными числами, и находит сумму элементов с нечётными индексами.");
    int size = 8;
    int[] numbers = new int[size];
    int result = 0; 
    FillArrayIntegers(numbers, -100, 100);
    PrintArrayIntegers(numbers);

    for (int i = 0; i < size; i++) if (i % 2 != 0) result += numbers[i];
    Console.WriteLine($"Сумма элементов массива с нечётными индексами равна {result}.");
    Console.WriteLine();
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива. [3,21 7,04 22,93 -2,71 78,24] -> 80,95.
void Task38()
{
    Console.WriteLine("Программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементами массива.");
    int size = 8;
    double[] numbers = new double[size];
    FillArrayDecimals(numbers);
    double result = 0;
    PrintArrayDecimals(numbers);
    SortArrayDecimals(numbers);

    for (int i = 0; i < size; i++) if (i % 2 != 0) result = numbers[size-1] - numbers[0];
    Console.WriteLine($"Разница между максимальным ({numbers[size-1]}) и минимальным ({numbers[0]}) элементами массива равна {result}");
    Console.WriteLine();
    Console.WriteLine();
}

void FillArrayIntegers(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rand.Next(minValue,maxValue);
    }
}
void PrintArrayIntegers(int[] nums)
{
    Console.WriteLine("Вывод массва:");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void FillArrayDecimals(double[] nums)
{
    Random rand = new Random();
    for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToDouble(new Random().Next(-100,1000)) / 100;
        }
}
void PrintArrayDecimals(double[] nums)
{
    Console.WriteLine("Вывод массва:");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void SortArrayDecimals(double[] nums)
{
     for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = 0; j < nums.Length - 1 - i; j++)
        {
            if (nums[j] > nums[j+1])
            {
                double temp = nums[j];
                nums[j] = nums[j+1];
                nums[j+1] = temp;
            }
        }
    }
}

Task34();
Task36();
Task38();
