using DesignPattern.Chain.BaseModel;
using System;
using System.Collections.Generic;

namespace DesignPattern.Chain.Implement
{
    public class CEO : BillHandler
    {
        private List<string> permissions = new List<string>() { "SAVE", "SUBMIT", "AUDIT" };

        public CEO(string userName)
        {
            base.UserName = userName;
            base.Permissions = permissions;
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
                bill.Status = BillStatus.Submitted;
                Console.WriteLine(string.Format("{0}：{1}已经审核！", this.UserName, bill.BilNo));
            }
        }
    }    
}
