using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    interface IUpdatable
    {
        void Update();
        void Update(char key);
    }
}
