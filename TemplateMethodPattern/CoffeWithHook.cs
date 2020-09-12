using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class CoffeWithHook : CaffeineBeverageWithHook
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override bool customerWantsCondiments()
        {
            string answer = getUserInput();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            return false;
        }

        private string getUserInput()
        {
            Console.WriteLine("Would you like sugar and milk? (y/n)");
            var ans = Console.ReadLine();
            return ans;
        }

        protected override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
