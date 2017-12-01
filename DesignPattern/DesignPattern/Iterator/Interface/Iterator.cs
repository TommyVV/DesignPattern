using System;

namespace DesignPattern.Iterator.Interface
{
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }
}
