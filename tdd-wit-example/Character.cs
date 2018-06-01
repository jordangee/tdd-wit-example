using System;
namespace tdd_wit_example
{
    public class Character
    {
        public int HP { get; private set;  }
        readonly int AC;

        public Character(int hitPoints = 10, int armorClass = 10)
        {
            HP = hitPoints;
            AC = armorClass;
        }

        void Hit(int damage) 
        {
            HP -= damage;

            if (HP < 0)
            {
                HP = 0;
            }
        }

        public void Heal(int health)
        {
            HP += health;
        }

        public bool ResolveAttack(int attack, int damage = 0)
        {
            bool attackDidHit = attack >= AC;
            if (attackDidHit) 
            {
                Hit(damage);
            }
            return attackDidHit;
        }
    }
}
