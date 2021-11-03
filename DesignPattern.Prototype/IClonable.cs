using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public interface IClonable<T>
    {
        T Clone(T obj);
    }
}
