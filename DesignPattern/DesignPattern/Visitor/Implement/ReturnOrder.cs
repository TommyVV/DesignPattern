using DesignPattern.Visitor.Base;

namespace DesignPattern.Visitor.Implement
{
    public class ReturnOrder:Order
    {
        public override void Accept(Visitors visitor)
        {
            visitor.Visit(this);
        }
    }
}
