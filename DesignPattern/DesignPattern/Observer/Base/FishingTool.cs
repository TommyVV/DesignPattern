using DesignPattern.Observer.Interface;
using DesignPattern.Observer.Model;
using System.Collections.Generic;

namespace DesignPattern.Observer.Base
{
    public abstract class FishingTool
    {
        private readonly List<ISubscriber> _subscribers;

        protected FishingTool()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void Notify(FishType type)
        {
            foreach (var subscriber in _subscribers)
                subscriber.Update(type);
        }        
    }
}
