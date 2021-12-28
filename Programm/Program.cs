// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Enter count of array numbers:");
int countOFArrayNumbers = int.Parse(Console.ReadLine());

int[] firstArray = new int [countOFArrayNumbers];

void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(- 50, 50);
    }
}

void PrintArray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i] + " ");
    }
}

Console.Write("Your array: [ " );
FillArray(firstArray);
PrintArray(firstArray);
Console.WriteLine("]");