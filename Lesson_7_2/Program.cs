int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, colums];

FillArray2D(numbers);
PrintArray2D(numbers);

double sum = 0;
double result = 0;

for (int j = 0; j < numbers.GetLength(1); j++)
{
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        sum += numbers[i, j];
    }
result = sum / numbers.GetLength(1);
result = Math.Round(result, 2);
Console.Write(result + "; ");
result = 0;
sum = 0;
}


void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//GetLength(0) - строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//GetLength(1) - столбцы
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}