using System;

namespace pr_4_5
{
    internal class WaterMage : Mage, ISpell
    {
        public WaterMage(string name, int magicLevel) : base(name, magicLevel)
        {
        }

        public override void Attack(Mage target)
        {
            int damage = MagicLevel * 2;
            Console.WriteLine($"{Name} кидає водяне закляття на {target.Name} і завдає {damage} пошкоджень.");
            target.Defend(damage);
        }

        public override void Defend(int damage)
        {
            Health -= damage / 2;
            Console.WriteLine($"{Name} захищається та витрачає частину енергії для зменшення пошкоджень.");
        }

        public void Cast(Mage target)
        {
            Console.WriteLine($"{Name} кидає водяне закляття на {target.Name}.");
        }
    }
}
