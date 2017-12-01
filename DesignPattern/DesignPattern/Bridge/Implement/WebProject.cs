using DesignPattern.Bridge.Base;
using System;

namespace DesignPattern.Bridge.Implement
{
    public class WebProject : Project
    {
        public WebProject(string projectName) : base(projectName)
        {
            Console.WriteLine(1);
        }

        public override void AnalyzeRequirement()
        {
            Console.WriteLine("需求分析");
        }

        public override void DesignProduct()
        {
            Console.WriteLine("产品设计");
        }

        public override void MakePlan()
        {
            Console.WriteLine("制定计划");
        }

        public override void ScheduleTask()
        {
            Console.WriteLine("任务分解");
        }

        public override void ControlProcess()
        {
            Console.WriteLine("进度把控");
        }

        public override void ReleaseProduct()
        {
            Console.WriteLine("产品发布");
        }

        public override void MaintainProduct()
        {
            Console.WriteLine("后期运维");
        }
    }
}
