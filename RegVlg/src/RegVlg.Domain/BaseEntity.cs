using System;
using System.Collections.Generic;
using System.Text;

namespace RegVlg.Domain
{
    public abstract class BaseEntity
    {
        public Guid Uid { get; set; }
    }
}
