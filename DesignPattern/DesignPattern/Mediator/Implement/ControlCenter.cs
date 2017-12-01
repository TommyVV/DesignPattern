using DesignPattern.Mediator.BaseModel;
using System;

namespace DesignPattern.Mediator.Implement
{
    public class ControlCenter : Role
    {
        public ControlCenter(AbstractMediator mediator)
            : base(mediator)
        {

        }
        private readonly string name = "住建局：";
        private static string rule;

        /// <summary>
        /// 当需大于供，限购
        /// 当供大于需，限建
        /// </summary>
        public void Limit()
        {
            int requirement = mediator.GetBuyRequirement();
            int buildingNum = mediator.GetCurrentHouseNumber();

            string strs = string.Format("{0}目前购房需求为：{1}套;现有房源：{2}套。", name, requirement, buildingNum);

            if (requirement > buildingNum)
            {
                Console.WriteLine(strs + "供小于需，开始实施限购政策");
                rule = "LimitBuy";
            }
            else
            {
                Console.WriteLine(strs + "供大于需，开始实施限建政策");
                rule = "LimitBuild";
            }
        }

        public string ShowRule()
        {
            return rule;
        }
    }
}
