﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public interface ICommand
    {
        public void execute();
        public void undo();
    }
}
