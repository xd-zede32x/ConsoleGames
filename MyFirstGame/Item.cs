using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Item : ICloneable
    {
        public string name;
        public int id;
        public bool isStack;
        public int count;
        public Item(string name, int id, bool isStack,int count = 1)
        {
            this.name = name;
            this.id = id;
            this.isStack = isStack;
            this.count = count;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
 
