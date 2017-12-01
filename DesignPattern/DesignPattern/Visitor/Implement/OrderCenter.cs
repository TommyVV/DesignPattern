using DesignPattern.Visitor.Base;
using System.Collections.Generic;

namespace DesignPattern.Visitor.Implement
{
    public class OrderCenter : List<Order>
    {
        public void Accept(Visitors visitor)
        {            
            var iterator = this.GetEnumerator();

            while (iterator.MoveNext())
            {
                iterator.Current.Accept(visitor);
            }
        }

    }    
}
