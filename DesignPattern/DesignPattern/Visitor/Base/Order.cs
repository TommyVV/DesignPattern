using DesignPattern.Visitor.Model;
using System;
using System.Collections.Generic;

namespace DesignPattern.Visitor.Base
{
    public abstract class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatorDate { get; set; }

        /// <summary>
        /// 单据品项
        /// </summary>
        public List<OrderLine> OrderItems { get; set; }
        public abstract void Accept(Visitors visitor);
    }
}
