using DesignPattern.Chain.BaseModel;
using System;
using System.Collections.Generic;

namespace DesignPattern.Chain.Implement
{
    public class Purchaser : BillHandler
    {
        private List<string> permissions = new List<string>() { "SAVE" };

        public Purchaser(string username)
        {
            base.UserName = username;
            base.Permissions = permissions;
            base.Successor = new Manager("经理--张经理");//在构造函数中指定下一个处理者
        }

        public override void DoBillOperation(Bill bill)
        {
            if (CheckPermission("SAVE") && bill.Status == BillStatus.Open)
            {
                bill.Status = BillStatus.Saved;
                Console.WriteLine(string.Format("{0}：{1}已经保存！", this.UserName, bill.BilNo));
            }

            if (CheckPermission("SUBMIT") && bill.Status == BillStatus.Saved)
            {
                bill.Status = BillStatus.Submitted;
                Console.WriteLine(string.Format("{0}：{1}已经提交！", this.UserName, bill.BilNo));
            }

            if (CheckPermission("AUDIT") && bill.Status == BillStatus.Submitted)
            {
                if (bill.Amount <= 5000)
                {
                    bill.Status = BillStatus.Submitted;
                    Console.WriteLine(string.Format("{0}：{1}已经审核！", this.UserName, bill.BilNo));
                }
                else
                {
                    this.Successor.DoBillOperation(bill);
                }

            }
            else
            {
                this.Successor.DoBillOperation(bill);
            }
        }
    }    
}
