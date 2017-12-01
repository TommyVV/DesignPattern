namespace DesignPattern.Memento.Modal
{
    public class ContactPerson
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public ContactPerson(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }    
}
