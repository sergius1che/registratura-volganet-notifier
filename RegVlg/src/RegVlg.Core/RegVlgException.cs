using System;

namespace RegVlg.Core
{
    public class RegVlgException : Exception
    {
        public RegVlgException()
            : base()
        {
        }

        public RegVlgException(string message)
            : base(message)
        {
        }

        public RegVlgException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
