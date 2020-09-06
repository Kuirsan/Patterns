using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class dumbCommand : ICommand
    {
        public void execute()
        {
            throw new NotImplementedException();
        }
    }
}
