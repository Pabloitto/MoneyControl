﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Entities.Base
{
    public abstract class EntityBase : IEntity
    {
        public long Id
        {
            get;
            set;
        }

        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
