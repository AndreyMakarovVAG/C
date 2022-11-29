Console.WriteLine("Введите числа через запятую ");
string outlet = Console.ReadLine();
int result = 0;

int [] numbers = ParseStringToArray(outlet);
PrintArray(numbers);

int[] ParseStringToArray(string outlet)
{
    int countNumbers = GetCountNumbersInString(outlet);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < outlet.Length; i++)
    {
        if (outlet[i] != ',')
        {
            substring += outlet[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(outlet[outlet.Length - 1] != ',')
    numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}

int GetCountNumbersInString(string outlet)
{
    int count;
    if(outlet[outlet.Length - 1] == ',')
    count = 0;
    else
    count = 1;

    for (int i = 0; i < outlet.Length; i++)
    {
        if(outlet[i] == ',')
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    result++;
}
Console.WriteLine();
Console.WriteLine($"Количеcтво чесел больше 0 = {result}");