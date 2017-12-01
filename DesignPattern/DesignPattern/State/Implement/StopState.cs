﻿using DesignPattern.State.Interface;
using System;

namespace DesignPattern.State.Implement
{
    public class StopState: ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine($"{car.Name}已启动，开始自动驾驶！");
            car.CurrentCarState = Car.RunState;
        }

        public void Stop(Car car)
        {
            Console.WriteLine("车辆已停止！");
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("车辆已停止！");
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("车辆已停止！");
        }

     
    }
}
