using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGame
{
    static class DataBase
    {
        public static List<Item> items;
        public static List<Enemu> enemies;

        public static void Load()
        {
            items = new List<Item>();
            enemies = new List<Enemu>();

            items.Add(new Item("Zed",1,true));



            enemies.Add(new Enemu("Morbuys", 0, 29, 2, 0));



        }

        public static Item GetItem(int ID,int count=1)
        {
            Item item = (Item)items.Find(I => I.id == ID).Clone();
            if (item != null)
            {
                if (item.isStack)
                {
                    item.count = count;
                }
                else
                {
                    item.count = 1;
                }
                return item;
            }
            else
            {
                return null;
            }
        }

        public static Enemu GetEnemu(int ID)
        {
            Enemu enumy = (Enemu)enemies.Find(E => E.Id == ID).Clone();

            if (enumy != null)
            {
                return enumy;
            }

            else
            {
                return null;
            }
        }
    }
}
