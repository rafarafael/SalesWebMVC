using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class IntegrityExcepetion : ApplicationException
    {
        public IntegrityExcepetion(string message) : base(message)
        {

        }
    }
}
