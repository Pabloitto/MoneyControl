using MoneyControl.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Entities.Accounts
{
    public class Account : EntityBase
    {
        public string Name { get; set; }
        public List<Input> Inputs { get; set; }
        public List<Output> Outputs { get; set; }
        public DateTime? LastMovement { get; set; }

        public Account()
        {
            this.Inputs = new List<Input>();
            this.Outputs = new List<Output>();
        }
    }
}
