using System;

namespace Composite
{
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException()
        {
        }

        public FileTreatmentException(string msg) : base(msg)
        {
        }
    }
}
