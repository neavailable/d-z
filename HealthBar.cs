using System;


class HealthBar
{
    private static void ShowHealthBar(int fillNumber, int maxBarSize)
    {
        Console.Write('[');
        for (int i = 0; i < maxBarSize; ++i)
        {
            if (i < fillNumber) Console.Write('#');
            else Console.Write('_');
        }
        Console.Write(']');
    }
    
    private static void HealthBarFunc()
    {
        Console.WriteLine("Provide percent:");
        const int percentStep = 10, maxBarSize = 10;;
        int fillNumber = int.Parse(Console.ReadLine()) / percentStep;
        
        ShowHealthBar(fillNumber, maxBarSize);
    }
    
    private static void Main() 
    {
        HealthBarFunc();
    }
}