using DesignPattern.Decorator.BaseModel;
using System;

namespace DesignPattern.Decorator.Implement
{
    public class ModelHouse : DecoratorHouse
    {
        public ModelHouse(AbstractHouse house) : base(house)
        {
        }

        /// <summary>
        /// 展示样板房细节
        /// </summary>
        private void ShowDetail()
        {
            Console.WriteLine(@"
* 没钱买房
* 没钱买房
* 没钱买房
* 没钱买房
* 没钱买房
* 没钱买房
* 没钱买房
* 没钱买房。");
        }

        public override void Show()
        {
            base.Show();
            ShowDetail();
        }
    }
}
