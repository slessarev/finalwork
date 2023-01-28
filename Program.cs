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
            Console.Write($"Введите {i}-й элемент массива: ");
            array[i] = Console.ReadLine();
        }
    return array;
}

int arraySize = EnterData("Введите размер массива");
string[] array = FillArray(arraySize);
for (int i = 0; i < arraySize; i++)
{
    Console.WriteLine(array[i]);    
}

