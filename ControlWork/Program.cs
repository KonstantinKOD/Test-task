// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int Input(string arg)
{
    int number;
    System.Console.Write($"Введите {arg}");
    while(!int.TryParse(Console.ReadLine()!, out number))
    {
        System.Console.WriteLine("Введен не верный размер массива!");
        System.Console.WriteLine("Размер массив не может равняться нулю.");
        System.Console.WriteLine("В размере массива не может быть букв.");
        System.Console.Write("Введите цифру больше ноля: ");
    }
    return number;
}
int length = Input("длинну массива больше ноля: ");
string[] array = CreateArray(length);


string[] CreateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

System.Console.WriteLine("\n-----------Ваш массив----------");
System.Console.Write("[");
System.Console.Write(string.Join(", ", array));
System.Console.WriteLine("]");

