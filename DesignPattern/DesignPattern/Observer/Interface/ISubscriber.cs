using DesignPattern.Observer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Interface
{
    public interface ISubscriber
    {
        void Update(FishType type);
    }
}
