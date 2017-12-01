namespace DesignPattern.Bridge.Base
{
    public abstract class Manager
    {
        protected Project CurrentProject { get; set; }

        protected Manager(Project project)
        {
            CurrentProject = project;
        }

        /// <summary>
        /// 制定计划
        /// </summary>
        public abstract void SchedulePlan();

        /// <summary>
        /// 任务分配
        /// </summary>
        public abstract void AssignTasks();

        /// <summary>
        /// 进度把控
        /// </summary>
        public abstract void ControlProcess();


        /// <summary>
        /// 项目管理
        /// </summary>
        public virtual void ManageProject()
        {
            SchedulePlan();
            AssignTasks();
            ControlProcess();
        }

    }
}
