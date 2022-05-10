/* 
*  Написать программу, которая из имеющего массива строк
*  формирует массив из строк, длина которых меньше либо равна
*  3 символам. Первоначальный массив можно ввести с клавиатуры,
*  либо задать на старте выполнения алгоритма. При решении не
*  рекомендуется пользоваться коллекциями, лучше обойтись
*  исключительно массивами.
*/

// Задачи:
// - задать массив строк разной длинны
// - создать новый массив, который будет вмещать строки
// длина которых 3 и менее символа.

void FillArray(string[] array)
{
    int massiveSize = array.Length;
    for (int i = 0; i < massiveSize; i++)
    {
        array[i] = Console.ReadLine();
    }
}

int PrintArrayAndCheckCount(string[] array) 
{
    int count = 0;
    int massiveSize = array.Length;
    for (int i = 0; i < massiveSize; i++)
    {
        System.Console.Write($"{array[i]} ");
        if (array[i].Length <= 3) // Создаётся счётчик элементов с 3 и менее символами
            count = count + 1;
    }
    System.Console.WriteLine();
    return count;
}

void PrintArray(string[] array)
{
    int massiveSize = array.Length;
    for (int i = 0; i < massiveSize; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void GetArrayResult(string[] arrayStrings, string[] arrayResult)
{
    int len = arrayStrings.Length;
    int controlSize = 3;
    int indexS = 0;
    int indexR = 0;
    while (indexS < len)
    {
        if (arrayStrings[indexS].Length <= controlSize)
        {
            arrayResult[indexR] = arrayStrings[indexS];
            indexR = indexR + 1;
        }
        indexS = indexS + 1;
    }
}

System.Console.WriteLine("Введите колчиство элементов массива:");
int sizeS = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[sizeS];

System.Console.WriteLine("Заполните массив:");
FillArray(arrayStrings);
int count = PrintArrayAndCheckCount(arrayStrings);
string[] arrayResult = new string[count];
GetArrayResult(arrayStrings, arrayResult);
PrintArray(arrayResult);