﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComponentPattern
{
    public class Waitress
    {
        private MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }
        public void PrintMenu()
        {
            _allMenus.Print();
        }
    }
}
