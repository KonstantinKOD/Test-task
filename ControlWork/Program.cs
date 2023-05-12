internal class Program
{
    private static void Main(string[] args)
    {
        int InputLength(string arg)
        {
            int number;
            Console.Write($"Введите {arg}");
            while (!int.TryParse(Console.ReadLine()!, out number))
            {
                Console.WriteLine("Введен не верный размер массива!");
                Console.WriteLine("Размер массив не может равняться нулю.");
                Console.WriteLine("В размере массива не может быть букв.");
                Console.Write("Введите цифру больше ноля: ");
            }
            return number;
        }
        int length = InputLength("длинну массива больше ноля: ");
        string[] array = FillArray(length);


        string[] FillArray(int length)
        {
            string[] array = new string[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                array[i] = Console.ReadLine();
            }
            return array;
        }

        Console.WriteLine("\n-----------Ваш массив----------");
        Console.Write("[");
        Console.Write(string.Join(", ", array));
        Console.WriteLine("]");

        // string[] arrayV1 = new string[array.Length];

        string[] NewArray(string[] array)
        {
            int newLength = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newLength++;
                }
            }

            string[] arrayV1 = new string[newLength];

            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    arrayV1[n] = array[i];
                    n++;
                }
            }
            return arrayV1;
        }

        void Print(string[] arrayV1)
        {
            Console.Write("[ ");
            for (int i = 0; i < arrayV1.Length; i++)
            {
                Console.Write($"‘{arrayV1[i]}‘ ");
            }
            Console.WriteLine("]");
        }

        NewArray(array);
        Console.WriteLine("\nНовый массив из строк, длина которых меньше, либо равна 3 символам.");
        Print(NewArray(array));
    }
}