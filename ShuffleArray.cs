using System;


class ShuffleArray
{
    private static void swapValues(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    
    private static void ShuffleArray(int[] array)
    {
        Random random = new Random();
        
        for (int i = 0; i < array.Length; ++i)
        {
            swapValues
            (
                ref array[random.Next(0, array.Length)], 
                ref array[random.Next(0, array.Length)]
            );
        }
    }
    
    private static void ShowArray(int[] array)
    {
        foreach (int element in array) Console.Write($"{element} ");
    }
    
    private static void Main() 
    {
        const int size = 5;
        int[] array = new int[size] { 1, 8, -3, 10, -55 };
        ShuffleArray(array);
        ShowArray(array);
    }
}