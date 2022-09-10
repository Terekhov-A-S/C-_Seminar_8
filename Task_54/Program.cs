// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
void createArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = new Random().Next(0, 11);
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

void sortArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1) - 1; countTwo++)
        {
            for (int countThree = 0; countThree < array.GetLength(1) - 1; countThree++)
            {
                if (array[countOne, countThree] < array[countOne, countThree + 1])
                {
                    int temp = 0;
                    temp = array[countOne, countThree];
                    array[countOne, countThree] = array[countOne, countThree + 1];
                    array[countOne, countThree + 1] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Создадим массив чисел от '0' до '10' и упорядочим эти числа по убыванию в каждом столбце");
Console.Write("Введите желаемое количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желаемое количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
createArray(array);
Console.WriteLine("Массив ДО упорядочивания: ");
PrintArray(array);
Console.WriteLine("Массив ПОСЛЕ упорядочивания: ");
sortArray(array);
PrintArray(array);
Console.WriteLine("Всего доброго!");
