namespace DesignPattern.Visitor.Model
{
    public class OrderLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
    }
}
