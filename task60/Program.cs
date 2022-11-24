// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] array = Create3DArray();
Console.WriteLine("Трехмерный массив с индексами каждого элемента:");
PrintArray(array);

// Метод вывода массива на экран
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

//Cоздание трёхмерного массива
int[,,] Create3DArray(int x = 2, int y = 2, int z = 2)
{
    int countNums = 99;
    int[,,] array = new int[x =2, y = 2, z = 2];
    int[] arr = new int[countNums];
    int num = 10;
    for (int i = 0; i < arr.Length; i++)
        arr[i] = num++;

    for (int i = 0; i < array.Length; i++)
    {
        int randomInd = new Random().Next(0, 99);
        int temp = arr[i];
        arr[i] = arr[randomInd];
        arr[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = arr[valueIndex++];
            }
        }
    }
    return array;
}