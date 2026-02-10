using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Sets the snake head's initial position to collumn 10 and row 5.
        int x = 10;
        int y = 5;
        // Main game loop that runs indefinitely.
        while (true)
        {
            Console.Clear();
            // Sets the snake head to the current position of the x and y integers.
            Console.SetCursorPosition(x, y);
            // Draws the snake head as a "O" character.
            Console.Write("O");
            // Pauses the game loop for 100 milliseconds to control the speed of the snake.
            Thread.Sleep(100);
            // Checks if a key is pressed. If so, it reads the key and updates the snake's position accordingly.
            if (Console.KeyAvailable)
            {
                // Reads the key that was pressed without displaying it in the console.
                ConsoleKey key = Console.ReadKey(true).Key;
                // The following if statements check which arrow key was pressed and update the x or y position of the snake head accordingly.
                if (key == ConsoleKey.UpArrow) y--;
                if (key == ConsoleKey.DownArrow) y++;
                if (key == ConsoleKey.LeftArrow) x--;
                if (key == ConsoleKey.RightArrow) x++;
            }

        }
    }

}