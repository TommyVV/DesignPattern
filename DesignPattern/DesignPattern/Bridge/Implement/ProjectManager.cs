using DesignPattern.Bridge.Base;
using System;

namespace DesignPattern.Bridge.Implement
{
    public class ProjectManager : Manager
    {
        public ProjectManager(Project currentProject) : base(currentProject)
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

        public override void ManageProject()
        {
            Console.WriteLine(string.Format("项目经理负责【{0}】：", base.CurrentProject.ProjectName));
            base.ManageProject();
        }

    }
}
