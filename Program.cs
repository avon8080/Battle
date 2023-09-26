using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {

            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);
            IArmor blackArmor = new BlackArmor("Black Steel Armor", 50);
            IWeapon axe = new Axe("Black Steel Axe", 8);

            ICombatant blackKnight = new Fighter("Black Knight", blackArmor, axe);

            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);

            fighter.Attack(badGuy);
            blackKnight.Attack(fighter);

        }

    }

}
