using System;

namespace DesignPattern.Composite.Base
{
    public abstract class Organization
    {
        /// <summary>
        ///     成员姓名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        ///     成员职位
        /// </summary>
        public string MemberPosition { get; set; }

        /// <summary>
        ///     直接上级
        /// </summary>
        public Organization ParentNode { get; set; }

        public void Display()
        {
            var basicInfo = string.Format("姓名：{0},职位：{1}", MemberName, MemberPosition);
            var parentInfo = ParentNode == null
                ? ""
                : string.Format("，直接上级：『姓名：{0},职位：{1}』", ParentNode.MemberName, ParentNode.MemberPosition);
            Console.WriteLine(basicInfo + parentInfo);
        }
    }
}
