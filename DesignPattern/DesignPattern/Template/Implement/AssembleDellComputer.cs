using DesignPattern.Template.BaseModel;
using System;

namespace DesignPattern.Template.Implement
{
    public class AssembleDellComputer : AssembleComputer
    {
        public override void BuildMainFramePart()
        {
            Console.WriteLine("组装Dell电脑的主板");
        }

        public override void BuildScreenPart()
        {
            Console.WriteLine("组装Dell电脑的显示器");
        }

        public override void BuildInputPart()
        {
            Console.WriteLine("组装Dell电脑的键盘鼠标");
        }
    }   
}
