using DesignPattern.Factory.Interface;
using DesignPattern.Factory.Model;
using System;
using System.Reflection;

namespace DesignPattern.Factory
{
    public static class SimpleFactory
    {
        public static AbstractCar Create(string  productType)
        {
            Type type = Type.GetType(productType, true, true);
            var instance = type?.Assembly.CreateInstance(productType) as IFactoryMethod;
            if (instance != null)
            {
                return instance.Create();
            }
            else
            {
                return new Implement.ConcreateFactoryA().Create();
            }
            
            
            //    switch (productType)
            //{
            //    case ProductEnum.ConcreateProductA:
            //         return new Implement.ConcreateFactoryA().Create();
            //    case ProductEnum.ConcreateProductB:
            //        return new Implement.ConcreateFactoryB().Create();
            //    default:
            //        return null;
            //}
        }
    }
}
