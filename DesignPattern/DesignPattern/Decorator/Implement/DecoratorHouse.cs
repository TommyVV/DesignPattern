using DesignPattern.Decorator.BaseModel;

namespace DesignPattern.Decorator.Implement
{
    public abstract class DecoratorHouse : AbstractHouse
    {
        private readonly AbstractHouse house;

        public DecoratorHouse(AbstractHouse house)
        {
            this.house = house;
        }
        public override void Show()
        {
            this.house.Show();
        }
    }    
}
