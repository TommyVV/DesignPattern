using DesignPattern.Factory.Interface;
using DesignPattern.Factory.Model;
using System;

namespace DesignPattern.Factory.Implement
{
    public class ConcreateFactoryA : IFactoryMethod
    {
        public AbstractCar Create()
        {            
            return new AbstractCar("AUDI A6");
        }
    }    
}
