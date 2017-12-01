using DesignPattern.State.Implement;
using DesignPattern.State.Interface;

namespace DesignPattern.State
{
    public class Car
    {
        public string Name { get; set; }

        public Car()
        {
            this.CurrentCarState = StopState;//初始状态为停车状态
        }

        internal static ICarState StopState = new StopState();
        internal static ICarState RunState = new RuningState();
        internal static ICarState SpeedDownState = new SpeedDownState();
        internal static ICarState SpeedUpState = new SpeedUpState();

        public ICarState CurrentCarState { get; set; }

        public void Run()
        {
            this.CurrentCarState.Drive(this);
        }

        public void Stop()
        {
            this.CurrentCarState.Stop(this);
        }

        public void SpeedUp()
        {
            this.CurrentCarState.SpeedUp(this);
        }
        public void SpeedDown()
        {
            this.CurrentCarState.SpeedDown(this);
        }     
    }
}
