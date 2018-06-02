using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta4
{
    public class Notification
    {
        public List<Error> Errors { get; set; } 

        public Notification()
        {
        }

        public void AddError(string message)
        {
            AddError(message, null);
        }

        public void AddError(string message, Exception ex)
        {
            Errors.Add(new Error(message, ex));
        }

        public String ErrorMessage()
        {
            return string.Join(",", Errors.Select(error => error.Message));
        }

        public String errorMessage(String separator)
        {
            return string.Join(separator, Errors.Select(error => error.Message));
        }

        public bool HasErrors()
        {
            return Errors.Count > 0;
        }
    }
}
