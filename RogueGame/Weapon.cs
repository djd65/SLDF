using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueGame
{
    public class Weapon
    {
        protected Weapon(int damage, int precision)
        {
            Damage = damage;
            Precision = precision;
        }
        public string DamageType;
        //DamageType can be Slashing, Piercing, or Blunt
        public int Damage;
        //(Base) Damage is a range from 1 to 999, indicates how much power a weapon has
        public int Precision;
        //Precision is from 1 to 100, indicates chance to hit
        public string Rarity;
        //Rarity can be Basic, Fine, Masterwork, Rare, Exotic or Legendary
        //public Random Random = new Random();
        //For calculating a range of damage

        //Calculates the damage one takes when someone attacks
        public int Attack(Weapon w, Armor a)
        {
            return (w.Damage / a.Protection) * 100;
        }
    }

    //Slashing Weapons, balanced damage and accuracy
    public class Dagger : Weapon
    {
        public Dagger()
            : base (10, 75)
        {
            DamageType = "Slashing";
            Rarity = "Basic";
        }
    }

    public class ShortSword : Weapon
    {
        public ShortSword()
            : base(15, 70)
        {
            DamageType = "Slashing";
            Rarity = "Basic";
        }
    }

    public class LongSword : Weapon
    {
        public LongSword()
            : base(20, 70)
        {
            DamageType = "Slashing";
            Rarity = "Basic";
        }
    }

    public class TwoHander : Weapon
    {
        public TwoHander()
            : base(32, 70)
        {
            DamageType = "Slashing";
            Rarity = "Fine";
        }
    }

    public class Scimitar : Weapon
    {
        public Scimitar()
            : base(30, 85)
        {
            DamageType = "Slashing";
            Rarity = "Fine";
        }
    }

    public class Axe : Weapon
    {
        public Axe()
            : base(46, 65)
        {
            DamageType = "Slashing";
            Rarity = "Fine";
        }
    }

    public class SharpenedDagger: Weapon
    {
        public SharpenedDagger()
            : base(55, 90)
        {
            DamageType = "Slashing";
            Rarity = "Masterwork";
        }
    }

    public class GreatAxe: Weapon
    {
        public GreatAxe()
            : base(88, 70)
        {
            DamageType = "Slashing";
            Rarity = "Masterwork";
        }
    }

    public class Katana : Weapon
    {
        public Katana()
            : base(120, 85)
        {
            DamageType = "Slashing";
            Rarity = "Rare";
        }
    }

    public class Scythe : Weapon
    {
        public Scythe()
            : base(210, 70)
        {
            DamageType = "Slashing";
            Rarity = "Rare";
        }
    }

    public class Kaladbolg : Weapon
    {
        public Kaladbolg()
            : base(303, 75)
        {
            DamageType = "Slashing";
            Rarity = "Exotic";
        }
    }

    public class ChaosBlade : Weapon
    {
        public ChaosBlade()
            : base(375, 85)
        {
            DamageType = "Slashing";
            Rarity = "Exotic";
        }
    }

    public class SangeAndYasha : Weapon
    {
        public SangeAndYasha()
            : base(500, 99)
        {
            DamageType = "Slashing";
            Rarity = "Legendary";
        }
    }

    public class StagCutterly : Weapon
    {
        public StagCutterly()
            : base(500, 70)
        {
            DamageType = "Slashing";
            Rarity = "Legendary";
        }
    }

    public class Eternity : Weapon
    {
        public Eternity()
            : base(600, 75)
        {
            DamageType = "Slashing";
            Rarity = "Legendary";
        }
    }


    //Piercing Weapons, favors accuracy over damage
    public class Spear : Weapon
    {
        public Spear()
            : base(10, 80)
        {
            DamageType = "Piercing";
            Rarity = "Basic";
        }
    }

    public class Lance : Weapon
    {
        public Lance()
            : base(19, 83)
        {
            DamageType = "Piercing";
            Rarity = "Basic";
        }
    }

    public class Trident : Weapon
    {
        public Trident()
            : base(35, 87)
        {
            DamageType = "Piercing";
            Rarity = "Fine";
        }
    }

    public class Pickaxe : Weapon
    {
        public Pickaxe()
            : base(40, 90)
        {
            DamageType = "Piercing";
            Rarity = "Fine";
        }
    }

    public class Rapier : Weapon
    {
        public Rapier()
            : base(55, 90)
        {
            DamageType = "Piercing";
            Rarity = "Masterwork";
        }
    }

    public class Estoc : Weapon
    {
        public Estoc()
            : base(70, 85)
        {
            DamageType = "Piercing";
            Rarity = "Masterwork";
        }
    }

    public class Partisan : Weapon
    {
        public Partisan()
            : base(84, 86)
        {
            DamageType = "Piercing";
            Rarity = "Rare";
        }
    }

    public class Javelin : Weapon
    {
        public Javelin()
            : base(100, 75)
        {
            DamageType = "Piercing";
            Rarity = "Rare";
        }
    }

    public class DragonSlayerSpear : Weapon
    {
        public DragonSlayerSpear()
            : base(110, 90)
        {
            DamageType = "Piercing";
            Rarity = "Exotic";
        }
    }

    public class Brionac : Weapon
    {
        public Brionac()
            : base(130, 85)
        {
            DamageType = "Piercing";
            Rarity = "Exotic";
        }
    }

    public class Kraitkin : Weapon
    {
        public Kraitkin()
            : base(300, 99)
        {
            DamageType = "Piercing";
            Rarity = "Legendary";
        }
    }

    public class RicardsRapier : Weapon
    {
        public RicardsRapier()
            : base(400, 85)
        {
            DamageType = "Piercing";
            Rarity = "Legendary";
        }
    }

    //Blunt Weapons, favors damage over accuracy

    public class Club : Weapon
    {
        public Club()
            : base(20, 60)
        {
            DamageType = "Blunt";
            Rarity = "Basic";
        }
    }

    public class Pole : Weapon
    {
        public Pole()
            : base(28, 70)
        {
            DamageType = "Blunt";
            Rarity = "Basic";
        }
    }

    public class Mace : Weapon
    {
        public Mace()
            : base(39, 65)
        {
            DamageType = "Blunt";
            Rarity = "Fine";
        }
    }

    public class Scepter : Weapon
    {
        public Scepter()
            : base(55, 68)
        {
            DamageType = "Blunt";
            Rarity = "Fine";
        }
    }

    public class Hammer : Weapon
    {
        public Hammer()
            : base(75, 60)
        {
            DamageType = "Blunt";
            Rarity = "Masterwork";
        }
    }

    public class Tonfa : Weapon
    {
        public Tonfa()
            : base(70, 70)
        {
            DamageType = "Blunt";
            Rarity = "Masterwork";
        }
    }

    public class BrassKnuckles : Weapon
    {
        public BrassKnuckles()
            : base(130, 69)
        {
            DamageType = "Blunt";
            Rarity = "Rare";
        }
    }

    public class MorningStar : Weapon
    {
        public MorningStar()
            : base(200, 66)
        {
            DamageType = "Blunt";
            Rarity = "Rare";
        }
    }

    public class MonkeyKingBar : Weapon
    {
        public MonkeyKingBar()
            : base(290, 76)
        {
            DamageType = "Blunt";
            Rarity = "Exotic";
        }
    }

    public class GodHand : Weapon
    {
        public GodHand()
            : base(360, 68)
        {
            DamageType = "Blunt";
            Rarity = "Exotic";
        }
    }

    public class Mjolnir : Weapon
    {
        public Mjolnir()
            : base(600, 60)
        {
            DamageType = "Blunt";
            Rarity = "Legendary";
        }
    }

    public class DragonTooth : Weapon
    {
        public DragonTooth()
            : base(800, 50)
        {
            DamageType = "Blunt";
            Rarity = "Legendary";
        }
    }

}

