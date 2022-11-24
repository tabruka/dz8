// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Объявление двумерного массива
int[,] array = new int[,] {{1, 4, 7, 2,},
                            {5, 9, 2, 3,},
                            {8, 4, 2, 4},
                            {5, 2, 6, 7}};

Console.WriteLine();
Console.WriteLine("Заданный массив");
PrintArray(array);
int minSum = Int32.MaxValue;
int indexRows = 0;

// Цикл поиска наименьшей суммы
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minSum)
    {
        minSum = sum;
        indexRows = indexRows + 1;
    }
}

Console.WriteLine($"Строка под номером {(indexRows)} является строкой с наименьшей суммой элементов. Сумма ее элементов равна {(minSum)}");

// Метод вывода массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}