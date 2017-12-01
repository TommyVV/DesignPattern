using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Visitor.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }        
    }
}
