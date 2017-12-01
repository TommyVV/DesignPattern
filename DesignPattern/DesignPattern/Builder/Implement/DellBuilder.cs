using DesignPattern.Builder.Model;

namespace DesignPattern.Builder.Implement
{
    public class DellBulider : Base.Builder
    {
        Computer dell = new Computer() { Band = "戴尔" };

        protected override void BuildMainFramePart()
        {
            dell.AssemblePart("主机");
        }

        protected override void BuildScreenPart()
        {
            dell.AssemblePart("显示器");
        }

        protected override void BuildInputPart()
        {
            dell.AssemblePart("键鼠");
        }

        /// <summary>
        /// 决定具体的组装步骤
        /// </summary>
        /// <returns></returns>
        public override Computer BuildComputer()
        {
            BuildMainFramePart();
            BuildScreenPart();
            BuildInputPart();
            return dell;
        }
    }
}
