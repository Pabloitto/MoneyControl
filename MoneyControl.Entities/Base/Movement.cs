using MoneyControl.Entities.Accounts;
using MoneyControl.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Entities.Base
{
    public abstract class Movement : EntityBase
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Recurrence Recurrence { get; set; }
        public decimal Amount { get; set; }
    }
}
