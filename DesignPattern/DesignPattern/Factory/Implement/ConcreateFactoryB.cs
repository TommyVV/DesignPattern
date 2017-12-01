using DesignPattern.Factory.Interface;
using DesignPattern.Factory.Model;

namespace DesignPattern.Factory.Implement
{
    public class ConcreateFactoryB : IFactoryMethod
    {

        public AbstractCar Create()
        {
            return new AbstractCar("BMW520");
        }
    }    
}
