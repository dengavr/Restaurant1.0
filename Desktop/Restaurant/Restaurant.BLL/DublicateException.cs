using System;

namespace Restaurant.BLL
{
    public class DublicateException : Exception
    {
        public DublicateException(string message) : base(message)
        {
        }
    }

}
