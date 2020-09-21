﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComponentPattern
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public  virtual MenuComponent GetChild(int indx)
        {
            throw new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }
        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }
        public virtual double GetPrice()
        {
            throw new NotImplementedException();
        }
        public virtual bool IsVegeterian()
        {
            throw new NotImplementedException();
        }
        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}
