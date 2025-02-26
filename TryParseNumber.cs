using System;


class TryParseNumber
{
    private static void TryParseNumberFunc()
    {
        bool numberProvided = false;
        do 
        {
            Console.WriteLine("Provide number");
            
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                Console.WriteLine($"That's the number!");
                numberProvided = true;
            }
            
            else Console.WriteLine("Its not a number! Try again");
            
        } while(!numberProvided);
    }

    private static void Main() 
    {
        TryParseNumberFunc();
    }
}