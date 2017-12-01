using System.Collections.Generic;

namespace DesignPattern.Chain.BaseModel
{
    public abstract class BillHandler
    {
        /// <summary>
        /// 单据处理者姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 单据处理者具有的权限
        /// </summary>
        public List<string> Permissions { get; set; }

        public bool CheckPermission(string permission)
        {
            return Permissions.Contains(permission);
        }

        //声明下一个处理者
        protected BillHandler Successor { get; set; }


        /// <summary>
        /// 处理单据
        /// </summary>
        /// <param name="bill"></param>
        public void HandleBill(Bill bill)
        {
            //单据处理从保存开始
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                this.DoBillOperation(bill);
            }
            else
            {
                this.Successor.DoBillOperation(bill);
            }
        }

        public abstract void DoBillOperation(Bill bill);

    }   
}
