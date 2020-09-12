using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverageWithHook
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }
        protected abstract void brew();
        protected abstract void addCondiments();
        private void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
