using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class DinnerMenuIterator : IIterator
    {
        private MenuItem[] _items;
        private int _position = 0;

        public DinnerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }
        bool IIterator.HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        object IIterator.Next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
