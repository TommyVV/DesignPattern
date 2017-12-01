using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.BaseModel
{
    public abstract class AbstractHouse
    {
        /// <summary>
        /// 面积
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 定义抽象方法--展示
        /// </summary>
        public abstract void Show();
    }
}
