// Задача: Написать программу,  которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на  старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)"] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите элементы массива через запятую:");
string[] array = Console.ReadLine().Split(',');

string[] result = GetShortStrings(array);
PrintArray(result);


string[] GetShortStrings(string[] array)
{
    int count = 0;
     // Подсчитываем количество строк, удовлетворяющих условию
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;

    // Заполняем новый массив строк
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
            index++;
        }
    }

    return result;
}

void PrintArray(string[] array)
{
    Console.WriteLine("Новый массив строк: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}