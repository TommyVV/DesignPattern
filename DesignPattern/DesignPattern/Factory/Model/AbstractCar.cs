using System;

namespace DesignPattern.Factory.Model
{
    public class AbstractCar
    {
        private string CarName { get; set; }

        public AbstractCar(string name)
        {
            CarName = name;
            Console.WriteLine(" Build  " + CarName);
            Console.ReadLine();
        }
    }
}
