using DesignPattern.Builder.Model;

namespace DesignPattern.Builder.Base
{
    public abstract class Builder
    {
        /// <summary>
        /// 组装主机
        /// </summary>
        protected abstract void BuildMainFramePart();

        /// <summary>
        /// 组装显示器
        /// </summary>
        protected abstract void BuildScreenPart();

        /// <summary>
        /// 组装输入设备（键鼠）
        /// </summary>
        protected abstract void BuildInputPart();

        /// <summary>
        /// 获取组装电脑
        /// 由具体的组装类决定组装顺序
        /// </summary>
        /// <returns></returns>
        public abstract Computer BuildComputer();
    }
}
