//Написать программу, которая 
// 1. из имеющегося массива строк 
// 2. формирует новый массив из строк, 
// 3. длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

MessageToTheUser();

void MessageToTheUser()
{
    Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine();
    string[] inputArray = input.Split(' ');

    string[] resultArray = FilterArray(inputArray);

    Console.WriteLine("Результат:");
    foreach (string item in resultArray)
    {
        Console.WriteLine(item);
    }
    Console.ReadLine();
}

string[] FilterArray(string[] inputArray)
{
    int resultLength = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultLength++;
        }
    }
    
    string[] resultArray = new string[resultLength];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }
    return resultArray;
}

