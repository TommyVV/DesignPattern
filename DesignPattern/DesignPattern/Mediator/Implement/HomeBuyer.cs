using DesignPattern.Mediator.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.Implement
{
    public class HomeBuyer : Role
    {
        private readonly string name = "购房市场：";
        public HomeBuyer(AbstractMediator mediator)
            : base(mediator)
        {

        }
        private static int requirement = 800;//购房需求

        public void BuyHouse(int num)
        {
            string rule = mediator.GetRule();

            Console.WriteLine(name + "需要买房：" + num + "套");

            if (rule != "LimitBuy")
            {
                requirement += num;
            }
            else
            {
                Console.WriteLine(name + "国家实例了限购政策，不允许购买");
            }
        }

        /// <summary>
        /// 签订购房合同
        /// </summary>
        /// <param name="num"></param>
        public void SignAgreement(int num)
        {
            requirement -= num;
            Console.WriteLine(string.Format("{0}成功购房{1}套", name, num));
        }

        public int GetRequirement()
        {
            return requirement;
        }
    }
}
