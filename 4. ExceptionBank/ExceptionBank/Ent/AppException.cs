using System;

namespace ExceptionBank.Ent
{
    internal class AppException : ApplicationException
    {
        public AppException(string message) : base(message) 
        { 
        }
    }
}
