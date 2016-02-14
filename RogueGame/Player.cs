using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    public class Player
    {
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        Player()
        {
            Armor = new Pants();
            Weapon = new Dagger();
        }

    }

}
