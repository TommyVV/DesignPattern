using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual decimal Price { get; set; }
    }
}
