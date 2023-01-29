// Написать программу, которая из имещегося массива строк, формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма.

int EnterData(string text) //Ввод размера массива
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string[] FillArray(int n) //Заполнение массива
{
    string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i+1}-й элемент массива: ");
            array[i] = Console.ReadLine();
        }
    return array;
}

int CountStringArray(string[] array) // Метод определения количества элементов, размер которых <=3
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4) count++;
    }
    return count;
}

string[] ThreeSymbbolsArray(int size, string[] array)
{
    string[] finalArray = new string[size];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4) 
        {
            finalArray[j]=array[i];
            j++;
        }
    }
    return finalArray;
}
Console.Clear();
int arraySize = EnterData("Введите размер массива: ");
string[] array = FillArray(arraySize);
int numOfThreeSymbols = CountStringArray(array);
string[] resultArray = ThreeSymbbolsArray(numOfThreeSymbols, array);

//вывод итогового массива
Console.WriteLine();
for (int i = 0; i < numOfThreeSymbols; i++)
{
    Console.WriteLine(resultArray[i]);    
}

