Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input command: ");
        switch (Console.ReadLine())
        {
            case "H1": H1(); break;
            case "H2": H2(); break;
            case "H3": H3(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

void H1()//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
{
    int[] array = new int[10];
    Random random = new Random();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write($"{array[i]},  ");
    if  (array[i] % 2 == 0)
        {
            count++;
        }
}
Console.WriteLine($"Количество чётных чисел: {count}");
}
void H2()//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
{
    int[] array = new int[10];
    Random random = new Random();
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-100000, 100000);
    Console.Write($"{array[i]},  ");
    if  (i % 2 != 0)
        {
            sum = sum + array[i];
        }
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
}
void H3()//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
{
    double[] array = new double[10];
    Random random = new Random(DateTime.Now.Millisecond);
    double max = 0;
    double min = 0;
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 10;
        Console.Write($"{array[i]},  ");
    }    
    for (int i = 0; i < array.Length; i++)
    {
        if  (array[i] > max)
            {
                max = array[i];
                min = max;
            }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < max && min > array[i])
            {
                min = array[i];
                
            }
        sum = max - min; 
    }
    sum = max - min;
    Console.WriteLine($"Значение min: {min}");
    Console.WriteLine($"Значение max: {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {sum}");
}    


