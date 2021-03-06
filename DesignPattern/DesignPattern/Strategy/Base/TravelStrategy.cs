﻿namespace DesignPattern.Strategy.Base
{
    public abstract class TravelStrategy
    {
        /// <summary>
        /// 目的地
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 预算
        /// </summary>
        public int Budget { get; set; }

        /// <summary>
        /// 旅游计划
        /// </summary>
        public abstract void TravelPlan();
    }
}
