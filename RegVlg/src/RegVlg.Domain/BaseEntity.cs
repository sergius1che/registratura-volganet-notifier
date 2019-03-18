using System;
using System.Collections.Generic;
using System.Text;

namespace RegVlg.Domain
{
    public interface IEntity
    {
        Guid Uid { get; set; }

        DateTime InsertDateUtc { get; set; }

        DateTime ChangeDateUtc { get; set; }
    }

    public abstract class BaseEntity : IEntity
    {
        public Guid Uid { get; set; }

        public DateTime InsertDateUtc { get; set; }

        public DateTime ChangeDateUtc { get; set; }
    }
}
