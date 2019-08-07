using System;
using System.Runtime.Serialization;

namespace E_Konsulat.Domain.Exceptions
{
    [Serializable]
    public class FormMappingException : Exception
    {
        public FormMappingException(string errorMessage) : base(errorMessage)
        {
        }

        public FormMappingException(string errorMessage, Exception innerException)
            : base(errorMessage, innerException)
        {
        }

        protected FormMappingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
