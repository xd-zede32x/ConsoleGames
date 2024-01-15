using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    class Player
    {
        public string name;
        public float playerHelth,playerHelthMax;
        public int playerPower,playerPowerMax;
        public float damage;
        public float arrmor;
        public Inventory inventory;
        public Player()
        {
            inventory = new Inventory();
          
            playerHelthMax = 20;
            playerPowerMax = 15;

            damage = 5;
            arrmor = 0;

            playerHelth = playerHelthMax;
            playerPower = playerPowerMax;
        }
    }
    
    class Inventory
    {
        public List<Item> items = new List<Item>();
        public void AddItems(Item item)
        {
            if (items.Count > 0)
            {
                for (int index = 0; index < items.Count; index++)
                {
                    if (item.id == items[index].id && items[index].isStack)
                    {
                        items[index].count += item.count;
                    }

                    else
                    {
                        items.Add(item);
                        break;
                    }
                }
            }
                
            else
            {
                items.Add(item);
            }
        }
        
        public void GetAllItems()
        {
            for (int index = 0; index < items.Count; index++)
            {
                Console.WriteLine($"{index}: {items[index].name}, количество: {items[index].count}");
            }
        }
    }
}
