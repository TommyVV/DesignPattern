using DesignPattern.Iterator.Interface;

namespace DesignPattern.Iterator.Implement
{
    public class ConcreteList : IListCollection
    {
        readonly string[] _collection;
        public ConcreteList()
        {
            _collection = new string[] { "A", "B", "C", "D" };
        }

        public Interface.Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return _collection.Length; }
        }

        public string GetElement(int index)
        {
            return _collection[index];
        }
    }   
}
