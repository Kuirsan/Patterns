using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            primitiveOperation1();
            primitiveOperation2();
            concreteOperation();
            hook();
        }

        protected virtual void hook()
        {
        }

        private void concreteOperation()
        {
            throw new NotImplementedException();
        }

        protected abstract void primitiveOperation2();

        protected abstract void primitiveOperation1();
    }
}
