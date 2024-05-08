using System;

namespace pr_4_5
{
    internal abstract class Mage
    {
        public string Name { get; private set; }
        public int MagicLevel { get; private set; }
        private int health;

        public event EventHandler<int> HealthChanged;

        public int Health
        {
            get { return health; }
            protected set
            {
                health = value;
                OnHealthChanged(health);
            }
        }

        public Mage(string name, int magicLevel)
        {
            Name = name;
            MagicLevel = magicLevel;
            Health = 100;
        }

        protected virtual void OnHealthChanged(int newHealth)
        {
            HealthChanged?.Invoke(this, newHealth);
        }

        public abstract void Attack(Mage target);
        public abstract void Defend(int damage);

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
