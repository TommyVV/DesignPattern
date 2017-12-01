using DesignPattern.Composite.Base;
using DesignPattern.Composite.Implement;
using System;

namespace DesignPattern.Composite
{
    public class Composite
    {
        public void Gate()
        {
            Console.WriteLine("组合模式：");
            Console.WriteLine("-------------------");

            var organzation = new Department("CEO", "老总");
            var developDepart = new Department("研发部经理", "研哥");
            var ssl = new Department("采购部总监", "tommy");
            organzation.Add(developDepart);
            organzation.Add(ssl);
            var projectA = new Department("Erp项目组长", "E哥");
            var projectB = new Department("负责人", "哈姐");
            developDepart.Add(projectA);
            ssl.Add(projectB);

            var memberX = new Member { MemberPosition = "开发工程师", MemberName = "开发X" };
            var memberY = new Member { MemberPosition = "开发工程师", MemberName = "开发Y" };
            var memberZ = new Member { MemberPosition = "测试工程师", MemberName = "测试Z" };
            var memberA = new Member { MemberPosition = "采购员", MemberName="采购A" };
            projectA.Add(memberX);
            projectA.Add(memberY);
            projectA.Add(memberZ);
            projectB.Add(memberA);
            Console.WriteLine("组合模式：从上往下遍历");
            DisplayStructure(organzation);
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine("组合模式：从下往上遍历");
            FindParent(memberX);
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }



        /// <summary>
        ///     正序排序
        /// </summary>
        /// <param name="org"></param>
        private static void DisplayStructure(Organization org)
        {
            if (org.ParentNode == null)
                org.Display();

            var departMent = (Department)org;
            var test = departMent.GetDepartmentMembers();
            foreach (var depart in test)
            {                
                depart.Display();                
                if (!(depart is Member))
                    DisplayStructure((Department)depart);
            }
        }

        /// <summary>
        ///     倒序排序
        /// </summary>
        /// <param name="member"></param>
        private static void FindParent(Organization member)
        {
            member.Display();
            while (member.ParentNode != null)
            {
                member.ParentNode.Display();
                member = member.ParentNode;
            }
        }
    }
}