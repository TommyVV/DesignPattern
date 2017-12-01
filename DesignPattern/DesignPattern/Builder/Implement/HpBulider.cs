using DesignPattern.Builder.Model;

namespace DesignPattern.Builder.Implement
{
    public class HpBulider : Base.Builder
    {
        Computer hp = new Computer() { Band = "惠普" };

        protected override void BuildMainFramePart()
        {
            hp.AssemblePart("主机");
        }

        protected override void BuildScreenPart()
        {
            hp.AssemblePart("显示器");
        }

        protected override void BuildInputPart()
        {
            hp.AssemblePart("键鼠");
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
            return hp;
        }
    }
}
