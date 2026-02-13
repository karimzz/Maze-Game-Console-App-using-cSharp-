using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Maze
    {
        private int _Width;
        private int _Height;
        private Player _Player;
        private IMazeObject [ , ] _MazeObjectArray;

        public Maze(int width , int height)
        {
            _Width = width;
            _Height = height;
            _MazeObjectArray = new IMazeObject[width, height];
            _Player = new Player()
            {
                X = 1 ,
                Y = 1
            };
            
        }

        public void DrawMaze()
        {

            Console.Clear();

            // Outer walls && exit
            for (int y = 0;  y < _Height; y++)
            {
                for (int x = 0; x < _Width; x++)
                {
                    // For make success exit
                    if ( (x == 37 && y == 19) || (x == 38 && y == 19))
                    {
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    // for make the border of the maze
                    else if ( (x == 0) || (y == 0) || (x == _Width - 1) || (y == _Height - 1)  )
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    // for make player 
                    else if(x == _Player.X && y == _Player.Y)
                    {
                        Console.Write(_Player.Icon);
                    }
                    // for make random wall in maze
                    else if(x % 3 == 0 && y % 3 == 0 )
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else if (x % 4 == 0 && y % 4 == 0)
                    {
                        _MazeObjectArray[x, y] = new Wall();
                        Console.Write(_MazeObjectArray[x, y].Icon);
                    }
                    else
                    {
                        // Empty Space
                        _MazeObjectArray[x, y] = new EmptySpace();
                        Console.Write(_MazeObjectArray[x, y].Icon); 
                    }
                    
                    
                }
                Console.WriteLine();
            }
        }

        public void MovePlayer()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            ConsoleKey key = userInput.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);
                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);
                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);
                    break;
            }

        }


        public void UpdatePlayer(int dx, int dy)
        {
            int newX = _Player.X + dx;
            int newY = _Player.Y + dy;

            if(newX < _Width && newX >= 0 && newY < _Height && newY >= 0 && _MazeObjectArray[newX , newY].IsSolid == false)
            {
                _Player.X = newX;
                _Player.Y = newY;
            }

        }

    }
}
