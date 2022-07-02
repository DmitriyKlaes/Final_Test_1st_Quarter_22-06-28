/*
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

string[] GetNewArray(int length)
{
    string[] result = new string[length];
    Console.WriteLine($"\nСоздан массив с колличеством элементов: {length}\n"
                      +"\nЗаполните массив:");
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"[{i}] <- ");
        string element = Console.ReadLine()!;
        if (string.IsNullOrEmpty(element))
        {
            element = "empty";
        }
        result[i] = element;
    }
    return result;
}

int FindSizeArray(string[] arrayFromFind, int textSize = 3)
{
    int count = 0;
    foreach (var textElement in arrayFromFind)
    {
        if (textElement.Length <= textSize)
        {
            count++;
        }
    }
    return count;
}

string[] FillResultArray(string[] arrayFromFill, int textSize = 3)
{
    int length = FindSizeArray(arrayFromFill);
    string[] result = new string[length];
    int index = 0;
    foreach (var textElement in arrayFromFill)
    {
        if (textElement.Length <= textSize)
        {
            result[index] = textElement;
            index++;
        }
    }
    return result;
}

string PrintArray(string[] arrayForPrint)
{
    return string.Join(", ", arrayForPrint);
}