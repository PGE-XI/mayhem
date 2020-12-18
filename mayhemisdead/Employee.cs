using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayhemisdead
{
    abstract class Employee
    {
        protected string ID;
        protected string name;
        protected string fullName;
        protected string type;
        protected float successRate;
        public int Count { get; set; }

        public virtual void Execute()
        {
            Count++;
        }
        public virtual void SuccessRate()
        {

        }
    }
}
