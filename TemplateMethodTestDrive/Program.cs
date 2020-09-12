using System;
using TemplateMethodPattern;

namespace TemplateMethodTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeWithHook coffeWithHook = new CoffeWithHook();
            Console.WriteLine("Making coffee");
            coffeWithHook.prepareRecipe();
        }
    }
}
