using ExamenParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParcial.Pregunta3
{
    public class PinterestSharer:Sharing
    {
        public void Share(string message)
        {
            Console.WriteLine("Message '" + message + "' shared on Pinterest");
        }

    }
}
