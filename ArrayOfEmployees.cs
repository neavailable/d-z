using System;


class ArrayOfEmployees
{
    
    private static string[] names     = new string [0];
    private static string[] jobTitles = new string [0];
    
    
    private static string[] AddElement(string[] array, string element)
    {
        string [] newArray = new string[array.Length + 1];
        for (int i = 0; i < array.Length; ++i) newArray[i] = array[i];
        newArray[newArray.Length - 1] = element; 
        return newArray;
    }
    
    private static string[] RemoveElement(string[] array)
    {
        string [] newArray = new string[array.Length - 1];
        for (int i = 0; i < newArray.Length; ++i) newArray[i] = array[i];
        return newArray;
    }
    
    private static void ShowData()
    {
        for (int i = 0; i < names.Length; ++i) 
        {
            Console.WriteLine($"{names[i]}-{jobTitles[i]}");
        }
    }
    
    private static void FindElement(string surname)
    {
        for (int i = 0; i < names.Length; ++i)
        {
            if (names[i] == surname)
            {
                Console.WriteLine
                ($@"
                    We found employee! His job title: {jobTitles[i]}
                ");
                return;
            }
        }
        Console.WriteLine("We couldn't found employee");
    }
    
    private static void Main() 
    {
        string userInput;
        do
        {
            Console.WriteLine
            ($@"
                Choose an option. 1 - add employee, 2 - show employees and data, 
                3 - fire last employee, 4 - find employee by surname and exit - exit
            ");
            userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                Console.WriteLine("Provide employee's name:");
                names = AddElement(names, Console.ReadLine());
                Console.WriteLine("Provide job title:");
                jobTitles = AddElement(jobTitles, Console.ReadLine());
            }
            
            else if (userInput == "2") ShowData();
            
            else if (userInput == "3") 
            {
                names     = RemoveElement(names);
                jobTitles = RemoveElement(jobTitles);
            }
            
            else if (userInput == "4")
            {
                Console.WriteLine("Provide employee's name:");
                FindElement(Console.ReadLine());
            }
        } while (userInput != "exit");
    }
}