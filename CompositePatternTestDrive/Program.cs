using ComponentPattern;
using System;

namespace CompositePatternTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("Pancake house menu", "breakfast");
            MenuComponent dinerMenu = new Menu("Diner Menu", "Lunch");
            MenuComponent cafeMenu = new Menu("Cafe Menu", "Dinner");
            MenuComponent dessertMenu = new Menu("Dessert menu", "Desert of course");

            MenuComponent allMenus = new Menu("All menus", "all menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spagetti", false, 3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple pie", "apple pie very delicious", true, 2.25));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
        }
    }
}
