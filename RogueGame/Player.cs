using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    public class Player : IMoveable, IUpdatable
    {
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public int XPos = 0;
        public int YPos = 0;

        public Player()
        {
            Armor = new Pants();
            Weapon = new Dagger();
        }

        public void UpdateXPosition(char x)
        {
            switch (x)
            {
                case 'l':
                    XPos -= 1;
                    break;
                case 'r':
                    XPos += 1;
                    break;
            }
        }

        public void UpdateYPosition(char y)
        {
            switch (y)
            {
                case 'u':
                    YPos += 1;
                    break;
                case 'd':
                    YPos -= 1;
                    break;
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Update(char key)
        {
            switch(key)
            {
                case 'w':
                    Console.WriteLine("U");
                    UpdateYPosition('u');
                    break;
                case 's':
                    Console.WriteLine("D");
                    UpdateYPosition('d');
                    break;
                case 'a':
                    Console.WriteLine("L");
                    UpdateXPosition('l');
                    break;
                case 'd':
                    Console.WriteLine("R");
                    UpdateXPosition('r');
                    break;
                default:
                    Console.WriteLine("Invalid Key Press");
                    break;
            }
        }

    }

}
