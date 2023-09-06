/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string [] CreateArray(int size)
{
    string [] array = new string [size];

    for (int i = 0; i < size; i++)
    {
        array [i] = Console.ReadLine();
    }

    return array; 
}

void ShowArray(string [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine(array[i]);
    }
}

string [] CreateNewArray(string [] array, int size)
{
    string [] new_array = new string [size];
    
    for (int j = 0; j < size; j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i].Length <= 3)
            {
                new_array [j] = array [i];
                j++;
            }
        }
    }

    return new_array;
}

int GetSizeNewArray(string [] array)
{
    int new_array_size = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            new_array_size++;
        }
    }
    
    return new_array_size;
}

int size = 0;

Console.Write("Enter the array size: ");
size = Convert.ToInt32(Console.ReadLine());
string [] arr = new string [size];

arr = CreateArray(size);

ShowArray(CreateNewArray(arr,GetSizeNewArray(arr)));
