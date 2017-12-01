using DesignPattern.Visitor.Implement;

namespace DesignPattern.Visitor.Base
{
    public abstract class Visitors
    {
        public abstract void Visit(SaleOrder saleOrder);
        public abstract void Visit(ReturnOrder returnOrder);
    }
}
