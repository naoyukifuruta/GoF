using System;

namespace Visitor
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
