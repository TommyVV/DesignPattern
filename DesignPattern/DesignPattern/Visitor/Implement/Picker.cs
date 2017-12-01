using DesignPattern.Visitor.Base;
using System;

namespace DesignPattern.Visitor.Implement
{
    public class Picker: Visitors
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override void Visit(SaleOrder saleOrder)
        {
            Console.WriteLine($"开始为销售订单【{saleOrder.Id}】进行销售捡货处理：");
            foreach (var item in saleOrder.OrderItems)
            {
                Console.WriteLine($"【{item.Product.Name}】商品* {item.Qty}");
            }

            Console.WriteLine($"订单【{saleOrder.Id}】捡货完毕！");

            Console.WriteLine("==========================");
        }

        public override void Visit(ReturnOrder returnOrder)
        {
            Console.WriteLine($"开始为退货订单【{returnOrder.Id}】进行退货捡货处理：");
            foreach (var item in returnOrder.OrderItems)
            {
                Console.WriteLine($"【{item.Product.Name}】商品* {item.Qty}");
            }

            Console.WriteLine($"退货订单【{returnOrder.Id}】退货捡货完毕！", returnOrder.Id);
            Console.WriteLine("==========================");
        }        
    }
}
