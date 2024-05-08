using System;

namespace pr_4_5
{
    internal class FireMage : Mage, ISpell
    {
        public FireMage(string name, int magicLevel) : base(name, magicLevel)
        {
        }

        public override void Attack(Mage target)
        {
            int damage = MagicLevel * 3;
            Console.WriteLine($"{Name} кидає вогняне закляття на {target.Name} і завдає {damage} пошкоджень.");
            target.Defend(damage);
        }

        public override void Defend(int damage)
        {
            Health -= damage / 2;
            Console.WriteLine($"{Name} захищається та витрачає частину енергії для зменшення пошкоджень.");
        }

        public void Cast(Mage target)
        {
            Console.WriteLine($"{Name} кидає вогняне закляття на {target.Name}.");
        }
    }
}
