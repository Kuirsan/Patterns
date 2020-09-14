using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Waiters
    {
        private DinerMenu _dinerMenu;

        public Waiters(DinerMenu dinerMenu)
        {
            _dinerMenu = dinerMenu;
        }
        public void PrintMenu()
        {
            IIterator dinerIterator = _dinerMenu.CreateIterator();
            Console.WriteLine("MENU --- Breakfast");
            PrintMenu(dinerIterator);
        }

        private void PrintMenu(IIterator dinerIterator)
        {
            while (dinerIterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)dinerIterator.Next();
                Console.WriteLine(menuItem.GetName());
            }
        }
    }
}
