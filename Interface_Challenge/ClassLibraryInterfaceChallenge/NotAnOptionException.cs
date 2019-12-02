using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryInterfaceChallenge
{
    public class NotAnOptionException : Exception
    {
        public NotAnOptionException(string message) : base(message)
        {

        }
    }
}
