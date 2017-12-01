using DesignPattern.Memento.Modal;
using System.Collections.Generic;

namespace DesignPattern.Memento.Implement
{
    public class ContactMemento
    {
        private readonly List<ContactPerson> _backupContactPersons;

        public List<ContactPerson> GetMemento()
        {
            return _backupContactPersons;
        }

        public ContactMemento(List<ContactPerson> backupContactPersons)
        {
            _backupContactPersons = backupContactPersons;
        }
    }
}
