using DesignPattern.Mediator.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.Implement
{
    public class Builder : Role
    {
        private readonly string name = "房地产商：";
        public Builder(AbstractMediator mediator)
            : base(mediator)
        {

        }

        private static int houseNum = 1000;

        public void BuildHouse()
        {
            int requirement = mediator.GetBuyRequirement();
            if (houseNum < requirement)
            {
                //房源不够，立马新建
                int needBuild = requirement - houseNum + 100;
                Console.WriteLine(name + "建房：" + needBuild + "套");
                houseNum += needBuild;
            }
        }

        public void SaleHouse(int num)
        {
            if (houseNum < num)
            {
                string rule = mediator.GetRule();

                if (rule != "LimitBuild")
                {
                    Console.WriteLine(name + "房源不够，正在建设中");
                    this.BuildHouse();
                }
            }
            else
            {
                houseNum -= num;
                Console.WriteLine(name + "卖房：" + num + "套");
                //告诉购房者签订合同
                mediator.HomeBuyer.SignAgreement(num);
            }
        }

        public int ShowHouseNum()
        {
            return houseNum;
        }
    }
}
