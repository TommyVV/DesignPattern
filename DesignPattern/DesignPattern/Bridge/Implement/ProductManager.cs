using DesignPattern.Bridge.Base;
using System;

namespace DesignPattern.Bridge.Implement
{
    public class ProductManager : Manager
    {
        public ProductManager(Project currentProject) : base(currentProject)
        {
        }

        public override void SchedulePlan()
        {
            base.CurrentProject.MakePlan();
        }

        public override void AssignTasks()
        {
            base.CurrentProject.ScheduleTask();
        }

        public override void ControlProcess()
        {
            base.CurrentProject.ControlProcess();
        }

        public void AnalyseRequirement()
        {
            base.CurrentProject.AnalyzeRequirement();
        }

        public void DesignProduct()
        {
            base.CurrentProject.DesignProduct();
        }

        public override void ManageProject()
        {
            Console.WriteLine(string.Format("产品经理负责【{0}】：", base.CurrentProject.ProjectName));
            AnalyseRequirement();
            DesignProduct();
            base.ManageProject();
        }
    }
}
