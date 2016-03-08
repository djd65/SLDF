using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    interface IMoveable
    {
        void UpdateXPosition(char x);
        void UpdateYPosition(char y);
    }
}
