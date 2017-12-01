using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Mediator.BaseModel
{
    public abstract class Role
    {
        protected AbstractMediator mediator;

        public Role(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
