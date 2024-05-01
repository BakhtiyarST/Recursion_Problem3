// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Enter the array length");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arrayInt = GenerateArrayInt32(n);
        Console.WriteLine("");
        Console.WriteLine("The conventional way to display array:");
        DisplayArrayConventional(arrayInt);
        Console.WriteLine("");
        Console.WriteLine("The alternative way to display array, both reversed and through recursion:");
        DisplayArray(arrayInt, 0);

    }

    static int[] GenerateArrayInt32(int n)
    {
        int[] arrayTmpInt = new int[n];
        Random rnd = new Random();

        for (int i = 0; i < arrayTmpInt.Length; i++)
            arrayTmpInt[i] = rnd.Next(0, 11);
        return arrayTmpInt;
    }

    static void DisplayArrayConventional(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            Console.WriteLine($"arrayInt[ {i} ] = {array[i]}");
    }

    static void DisplayArray(int[] array, int index)
    {
        int n = array.Length;
        if (index < n)
        {
            DisplayArray(array, index + 1);
            Console.WriteLine($"array[ {index} ] = {array[index]}");
        }
    }
}