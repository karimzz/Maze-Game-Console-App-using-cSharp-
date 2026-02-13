using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Player : IMazeObject
    {
        public int X { get; set; }
        public int Y { get; set; }


        public char Icon { get => '@';  }
        public bool IsSolid { get => true; }

    }
}
