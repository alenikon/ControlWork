Console.Clear();
Console.WriteLine("Введите предложение");
string? userString = Console.ReadLine();
string[] IncomingArray = userString.Split(' ');
Console.WriteLine("Введите максимальную длину слова в предложении:");
int maxLength = Convert.ToInt32(Console.ReadLine());
// Создание нового массива shortArray с длинами слов не более maxLength
string[] shortArray = FinalArray(IncomingArray);
Console.WriteLine($"Итоговый массив с длинами слов не более {maxLength} символов");
// Вывод результирующего массива shortArray
PrintArray(shortArray);

// Метод для нахождения массива с элементами не более maxLength букв
string[] FinalArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}
// Метод для вывода результирующего массива
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Во введенной строке нет слов искомой длины");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}