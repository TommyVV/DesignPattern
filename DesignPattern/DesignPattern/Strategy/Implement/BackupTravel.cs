﻿using DesignPattern.Strategy.Base;
using System;

namespace DesignPattern.Strategy.Implement
{
    public class BackupTravel : TravelStrategy
    {
        public BackupTravel()
        {
            this.PlanName = "逛街看电影包饺子！";
        }
        public override void TravelPlan()
        {
            Console.WriteLine("备用旅游计划：");
            Console.WriteLine(string.Format("计划名称：{0}", this.PlanName));
        }
    }
}
