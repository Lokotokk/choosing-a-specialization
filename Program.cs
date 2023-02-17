// Написать программу, которая 
// 1. из имеющегося массива из строк 
// 2. формирует массив 
// (задается с клавиатуры либо на страте выполнения алгоритма) 
// из строк, длина которых меньше либо равна 3 символов.

string[] text = new string[5];
FillArray(text);
PrintArrayString(text);
string[] newText = CreateArray(text);
PrintArrayString(newText);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива:     ");
        array[i] = Console.ReadLine();
    }

}

void PrintArrayString(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

string[] CreateArray(string[] arr)
{
    int newArrSize = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) newArrSize++;
    }
    string[] newArr = new string[newArrSize];
    int index = 0;
    for (int j = 0; j < arr.Length; j++)
        if (arr[j].Length <= 3)
        {
            newArr[index] = arr[j];
            index++;
        }
    return newArr;
}

