using System;

namespace Homework11.BLL.Validation
{
    public class ValidationException: Exception
    {
        public string Property { get; protected set; }
        public ValidationException(string message, string propert) : base(message)
        {
            Property = propert;
        }
    }
}
