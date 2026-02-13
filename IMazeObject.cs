using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IMazeObject
    {
        char Icon { get;  } // The shape of maze object
        bool IsSolid { get;  } // Movement block
    }
}
