using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Sets the snake head's initial position to collumn 10 and row 5.
        

        //Setting the boundaries of the game to the current size of the console window.
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;

        int x = (width - 2) / 2 + 1;
        int y = (height - 2) / 2 + 1;

        // Main game loop that runs indefinitely.
        while (true)
        {
            Console.Clear();
           
            // Draws the borders as "|", "-", and "+" characters.

            for (int xx = 0; xx < width; xx++)
            {
                // Top row
                if (xx == 0 || xx == width - 1)
                {
                    Console.SetCursorPosition(xx, 0);
                    Console.Write("+"); // corners
                }
                else
                {
                    Console.SetCursorPosition(xx, 0);
                    Console.Write("-");
                }

                // Bottom row
                if (xx == 0 || xx == width - 1)
                {
                    Console.SetCursorPosition(xx, height - 1);
                    Console.Write("+"); // corners
                }
                else
                {
                    Console.SetCursorPosition(xx, height - 1);
                    Console.Write("-");
                }
            }

            // Vertical walls (left and right)
            for (int yy = 1; yy < height - 1; yy++) // skip corners
            {
                Console.SetCursorPosition(0, yy);
                Console.Write("|");
                Console.SetCursorPosition(width - 1, yy);
                Console.Write("|");
            }
            // Sets the snake head to the current position of the x and y integers.
            Console.SetCursorPosition(x, y);
            // Draws the snake head as a "O" character.
            Console.Write("O");
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

            // Checks if the snake head has moved beyond the boundaries of the console window. If so, it wraps around to the opposite side.
            if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
            {
                // If the snake head goes out of bounds, the game is over. It clears the console and displays a game over message.
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Game Over! Press any key to exit.");
                break;
            }

            // Pauses the game loop for 100 milliseconds to control the speed of the snake.
            Thread.Sleep(100);

        }
    }

}