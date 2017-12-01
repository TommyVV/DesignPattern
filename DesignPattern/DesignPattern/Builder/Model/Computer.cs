using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder.Model
{
    public class Computer
    {
        /// <summary>
        /// 品牌
        /// </summary>
        public string Band { get; set; }

        /// <summary>
        /// 电脑组件列表
        /// </summary>
        private List<string> assemblyParts = new List<string>();

        /// <summary>
        /// 组装部件
        /// </summary>
        /// <param name="partName">部件名称</param>
        public void AssemblePart(string partName)
        {
            this.assemblyParts.Add(partName);
        }

        public void ShowSteps()
        {
            Console.WriteLine("开始组装『{0}』电脑:", Band);
            foreach (var part in assemblyParts)
            {
                Console.WriteLine(string.Format("组装『{0}』;", part));
            }

            Console.WriteLine("组装『{0}』电脑完毕！", Band);
        }
    }    
}
