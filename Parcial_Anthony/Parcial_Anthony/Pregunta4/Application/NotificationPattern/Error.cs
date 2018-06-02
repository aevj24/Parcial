using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4
{
    public class Error
    {
        public string Message { get; set; }
        public Exception Cause { get; set; }

        public Error(string message, Exception cause)
        {
            Message = message;
            Cause = cause;
        }
    }
}
