// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
void CreateArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = new Random().Next(-100, 101);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            Console.Write(array[countOne, countTwo] + " ");
        }
        Console.WriteLine("");
    }
}
void RowSmallestAmount(int[,] array)
{
    {
        int min = Int32.MaxValue;
        int row = 0;
        for (int countOne = 0; countOne < array.GetLength(0); countOne++)
        {
            int sum = 0;
            for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
            {
                sum = array[countOne, countTwo] + sum;
            }
            Console.WriteLine(sum);
            if (min > sum)
            {
                min = sum;
                row = countOne + 1;
            }
        }
        Console.WriteLine($"Наименьшая сумма элементов: {min}, находится в строке: {row}");
    }
}
Console.WriteLine("Создадим массив чисел от '-100' до '100', посчитаем сумму элементов в каждой строке и выведем номер строки с наименьшей суммой");
Console.Write("Введите желаемое количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желаемое количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
CreateArray(array);
Console.WriteLine("Вновь созданный массив: ");
PrintArray(array);
Console.WriteLine("Массив ПОСЛЕ подсчета сумм: ");
RowSmallestAmount(array);
Console.WriteLine("Всего доброго!");



