using DesignPattern.Mediator.Implement;

namespace DesignPattern.Mediator.BaseModel
{
    public abstract class AbstractMediator
    {
        /// <summary>
        /// 使用属性注入
        /// 因为中介可能只需要和部分角色（模块）交互
        /// </summary>
        public HomeBuyer HomeBuyer { get; set; }
        public Implement.Builder HouseBuilder { get; set; }
        public ControlCenter ControlCenter { get; set; }

        /// <summary>
        /// 获取购房需求
        /// </summary>
        /// <returns></returns>
        public abstract int GetBuyRequirement();

        /// <summary>
        /// 获取房源数目
        /// </summary>
        /// <returns></returns>
        public abstract int GetCurrentHouseNumber();

        /// <summary>
        /// 获取楼市政策
        /// </summary>
        /// <returns></returns>
        public abstract string GetRule();

    }
    public class Mediator : AbstractMediator
    {
        public override int GetBuyRequirement()
        {
            return base.HomeBuyer.GetRequirement();
        }

        public override int GetCurrentHouseNumber()
        {
            return base.HouseBuilder.ShowHouseNum();
        }

        public override string GetRule()
        {
            return base.ControlCenter.ShowRule();
        }
    }    
}
