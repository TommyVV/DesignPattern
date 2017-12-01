using DesignPattern.Decorator.BaseModel;
using System;

namespace DesignPattern.Decorator.Implement
{
    public class WithoutDecoratorHouse : AbstractHouse
    {
        /// <summary>
        /// 毛坯房就做简要展示
        /// </summary>
        public override void Show()
        {
            Console.WriteLine(string.Format("该户型为{0}㎡，户型设计为{1}，目前均价为{2}元/㎡。", this.Area, this.Specification, this.Price));
        }
    }
}
