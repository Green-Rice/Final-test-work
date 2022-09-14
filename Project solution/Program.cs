
Console.WriteLine("Hello, World!");
/*Напишите программу, которая из имеющегося массива строк сформирует массив из строк, длина которых меньше либо ровна 3 символам. Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Примеры:
["Hello","2",":-)"] => ["2",":-)"]*/

void mainFunction(string[] array, string[] arrayTwo)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayTwo[temp] = array[i];
            temp++;
        }
    }
}


void printArray(string[] arrayTwo)
{
    for (int i = 0; i < arrayTwo.Length; i++)
    {
        System.Console.Write($"{arrayTwo[i]}\t");
    }
}

string[] array = { "Hello", "2", "GB", "Ерофеев" };
string[] arrayTwo = new string[array.Length];


mainFunction(array, arrayTwo);
printArray(arrayTwo);
