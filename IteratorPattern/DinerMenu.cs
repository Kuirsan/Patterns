using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class DinerMenu
    {
        static readonly int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator(_menuItems);
        }
    }
}
