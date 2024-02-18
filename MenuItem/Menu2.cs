using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Menu2
    {
        private static List<MenuItemCore> MenuItem=new List<MenuItemCore>();
        
        public static void ClearItem()
        {
            Menu2.MenuItem.Clear();
        }

        public static void AddItem(MenuItemCore menuItem)
        {
            Menu2.MenuItem.Add(menuItem);
        }
        public static void Execute()
        {
            int iMenu = IOUtils.SafeReadInteger("mi",null)-1;
            if (iMenu >= 0 && iMenu < Menu2.MenuItem.Count)
            {
                Menu2.MenuItem.ToArray()[iMenu].Execute();
            }
            else
            {
                Console.WriteLine("MenuItem not found");
            }



        }
        public static void ShowMenu() 
        {
            Console.WriteLine("==MENU==");

            int iMenuItem = 1;
            foreach (MenuItemCore menuItem in Menu2.MenuItem)
            {
                Console.WriteLine("{0}: {1}",iMenuItem++,menuItem.Title);
            }
        }
    }
}
