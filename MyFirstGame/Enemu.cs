using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Enemu : ICloneable
    {
        public string Name;
        public int Id;
        public float MaxHealth, Health;
        public float Damage;
        public float Arrmor;

        public Enemu(string name,int id,int maxHealth, float damage,float arrmor)
        {
            Name = name;
            Id = id;
            MaxHealth = maxHealth;
            Damage = damage;
            Arrmor = arrmor;


            Health = MaxHealth;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
