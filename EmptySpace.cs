using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class EmptySpace : IMazeObject
    {
        public char Icon { get => ' '; }
        public bool IsSolid { get => false;  }
    }
}
