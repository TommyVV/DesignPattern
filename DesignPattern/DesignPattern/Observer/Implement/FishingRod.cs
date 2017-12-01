using DesignPattern.Observer.Base;
using DesignPattern.Observer.Model;
using System;

namespace DesignPattern.Observer.Implement
{
    public class FishingRod:FishingTool
    {
        public void Fishing()
        {
            Console.WriteLine("开始下钩！");

            //用随机数模拟鱼咬钩，若随机数为偶数，则为鱼咬钩
            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType)new Random().Next(0, 7);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                Notify(type);
            }
            else
            {
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                Notify(FishType.空钩);
            }
        }
    }
}
