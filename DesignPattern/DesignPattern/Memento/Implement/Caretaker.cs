using System.Collections.Generic;

namespace DesignPattern.Memento.Implement
{
    public class Caretaker
    {
        // 存储多个备份
        public Dictionary<string, ContactMemento> ContactMementoes { get; set; }
        public Caretaker()
        {
            ContactMementoes = new Dictionary<string, ContactMemento>();
        }
    }
}
