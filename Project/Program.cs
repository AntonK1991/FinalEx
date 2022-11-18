//1. Создать репозиторий на GitHub
//2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
//3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
//4. Написать программу, решающую поставленную задачу
//5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, 
//как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

int InputArrayLength(string data)
{
    Console.Write(data);
    int count = Convert.ToInt32(Console.ReadLine());
    if (count > 0) return count;
    else return InputArrayLength("Значение должно быть больше 0! Повторите ввод: ");
}

string[] InputArrayElements(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int CheckDesiredElement(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] TransferElements(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
  Console.WriteLine("\nИскомые элементы массива: ");
  System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    System.Console.WriteLine("]");
}

Console.WriteLine();
int amount = InputArrayLength("Введите количество элементов массива: ");
string[] List = new string[amount];
InputArrayElements(List);
int amount2 = CheckDesiredElement(List);
if (amount2 == 0) Console.WriteLine("Отстуствуют элементы массива, отвечающие критериям поиска!");
else
{
    string[] newList = new string[amount2];
    TransferElements(List, newList);
    PrintArray(newList);
}