using System;

class Rogalik
{
    private static char playerChar = '$';
    private static int sizeX = 45, sizeY = 10;  
    private static string[] map = new string[10] 
    {
        "[===========================================]",
        "[          ###                   # #        ]",
        "[          ###                  #   #       ]",
        "[          ###                 #     #      ]",
        "[          ###                 #######      ]",
        "[       ###   ###                   ##      ]",
        "[      #   # #   #                  ##      ]",
        "[       ###   ###                           ]",
        "[                                           ]",
        "[===========================================]",
    };
    private static int x, y;
    
    private static void Main() 
    {
        CreatePlayer();
        
        char userInput;
        do
        {           
            Console.Clear();
            PrintMap();
            userInput = Console.ReadKey().KeyChar;
            InputHandling(userInput);
        } while (userInput != 'q');

    }
    
    private static void SetCharInMap(char character, int x_, int y_)
    {
        char[] row = map[y_].ToCharArray();
        row[x_] = character;
        map[y_] = new string(row);
    }
        
    private static void InputHandling(char input)
    {
        int previuosX = x, previuosY = y;
        
        if (input == 'w') --y;
        
        else if (input == 'a') --x;

        else if (input == 's') ++y;
        
        else if (input == 'd')++x;
        
        
        if (map[y][x] != ' ') 
        {
            x = previuosX; y = previuosY;
            return;
        }
        
        SetCharInMap(playerChar, x, y);
        SetCharInMap(' ', previuosX, previuosY);
    }
    
    private static void CreatePlayer()
    {
        Random random = new Random();
        
        do
        {
            x = random.Next(0, sizeX);
            y = random.Next(0, sizeY);
        } while (map[y][x] != ' ');
        
        SetCharInMap(playerChar, x, y);
    }
    
    private static void PrintMap()
    {
        foreach (string element in map) Console.WriteLine(element);
    }
}